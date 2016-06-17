using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using DBFSender.DBFSetTableAdapters;
using DBFSender.Properties;

namespace DBFSender
{
    public partial class DBFSenderForm : Form
    {
        public DBFSenderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            var filename = string.Empty;
            var destFile = string.Empty;
            var zipDest = string.Empty;
            var dbs = Settings.Default.DBFFiles;

            if (Directory.Exists(sourceDir) && Directory.Exists(destDir))
            {
                string[] files = Directory.GetFiles(sourceDir);
                //Move all the files to the temp folder to be zipped
                foreach (string s in files)
                {
                    filename = Path.GetFileName(s);
                    if (dbs.Contains(filename))
                    {
                        destFile = Path.Combine(tempDir, filename);
                        File.Copy(s,destFile,true);
                    }
                }
                //Zip the folder
                zipDest = Path.Combine(destDir, Settings.Default.ZipFilename);
                if (File.Exists(zipDest)) File.Delete(zipDest);
                ZipFile.CreateFromDirectory(tempDir, zipDest);
                //Clean the temp folder
                if (Settings.Default.CleanTempFolderFlag)
                {
                    files = Directory.GetFiles(tempDir);
                    foreach (var s in files)
                    {
                        File.Delete(s);
                    }
                }
            }
        }
    }
}
