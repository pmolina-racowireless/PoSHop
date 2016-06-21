using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using DBFSender.Datasets;
using DBFSender.Datasets.DBFSetTableAdapters;
using DBFSender.Entity.Models;
using DBFSender.Properties;
using DBFSender.Entity.Helpers;
using log4net;

namespace DBFSender
{
    public partial class DBFSenderForm : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DBFSenderForm));
        public DBFSenderForm()
        {
            InitializeComponent();
        }

        private void DBFSenderForm_Load(object sender, EventArgs e)
        {

            var dbfSet = new DBFSet();
            var factTA = new FacturaTableAdapter();
            dbfSet.DataSetName = "DBFSet";
            dbfSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            factTA.Fill(dbfSet.Factura);
            dataGridView1.DataSource = dbfSet.Factura;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var sourceDir = Settings.Default.SourceDirectory;
            var destDir = Settings.Default.DestDirectory;
            var tempDir = Settings.Default.TempDirectory;
            var dbs = Settings.Default.DBFFiles;

            Logger.InfoFormat($"Empezando proceso de subida de Facturas.  Fecha: {DateTime.Now}");
            if (Directory.Exists(sourceDir) && Directory.Exists(destDir))
            {
                var files = Directory.GetFiles(sourceDir);
                //Move all the files to the temp folder to be zipped
                foreach (var s in files)
                {
                    var filename = Path.GetFileName(s);
                    if (filename != null && dbs.Contains(filename))
                    {
                        var destFile = Path.Combine(tempDir, filename);
                        try
                        {
                            File.Copy(s, destFile, true);
                        }
                        catch (Exception)
                        {
                            Logger.Error("Proceso ha fallado tratando de mover los archivos temporales");
                            throw;
                        }
                        
                    }
                }
                //Zip the folder
                var zipDest = Path.Combine(destDir, Settings.Default.ZipFilename);
                if (File.Exists(zipDest)) File.Delete(zipDest);
                ZipFile.CreateFromDirectory(tempDir, zipDest);
                //Clean the temp folder
                if (Settings.Default.CleanTempFolderFlag)
                {
                    files = Directory.GetFiles(tempDir);
                    foreach (var s in files)
                    {
                        try
                        {
                            File.Delete(s);
                        }
                        catch (Exception)
                        {
                            Logger.ErrorFormat($"No se pudo borrar el archivo temporal {s}");
                            throw;
                        }

                    }
                }
            }
            TransferToSQL();
        }

        private static void TransferToSQL()
        {
            var dbfSet = new DBFSet();
            var movmaTA = new movmaTableAdapter();
            var movdeTA = new movdeTableAdapter();
            movmaTA.FillToSync(dbfSet.movma);

            var db = new PoSHopDb();
            var movma = db.Set<movma>();
            var movmaList = dbfSet.movma.ConvertToList<movma>();

            movma.AddRange(movmaList);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                Logger.Error("Proceso de subida de movma ha fallado");
                throw;
            }


        }

    }
}
