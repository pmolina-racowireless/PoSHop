using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using DBFSender.Properties;

namespace DBFSender.Entity.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PoSHopDb : DbContext
    {
        public PoSHopDb()
            : base("name=PoSHopDb")
        {
            var connstr =
                "data source=173.248.130.10,1533;initial catalog=PoSHop;persist security info=True;user id=sa;password=InN0v02007t3@M;MultipleActiveResultSets=True;App=EntityFramework";
            //var originalConnectionString = Database.Connection.ConnectionString;
            //var entityBuilder = new EntityConnectionStringBuilder(originalConnectionString);
            //var factory = DbProviderFactories.GetFactory(entityBuilder.Provider);
            //var providerBuilder = factory.CreateConnectionStringBuilder();
            //providerBuilder.ConnectionString = entityBuilder.ProviderConnectionString;

            //providerBuilder.Add("Password", "InN0v02007t3@M");
            //entityBuilder.ProviderConnectionString = providerBuilder.ToString();
            Database.Connection.ConnectionString = connstr;
            Database.Connection.Open();

        }

        public virtual DbSet<movde> movdes { get; set; }
        public virtual DbSet<movma> movmas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<movde>()
                .Property(e => e.buscar)
                .IsUnicode(false);

            modelBuilder.Entity<movde>()
                .Property(e => e.doc)
                .IsUnicode(false);

            modelBuilder.Entity<movde>()
                .Property(e => e.almacen)
                .IsUnicode(false);

            modelBuilder.Entity<movde>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movde>()
                .Property(e => e.precio)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movde>()
                .Property(e => e.costo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movde>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movde>()
                .Property(e => e.flujo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movde>()
                .Property(e => e.unidad)
                .IsUnicode(false);

            modelBuilder.Entity<movde>()
                .Property(e => e.serial)
                .IsUnicode(false);

            modelBuilder.Entity<movde>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<movde>()
                .Property(e => e.statussync)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.doc)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.flujo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.entidad)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.pagares)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.inicial)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.descper)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.descval)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.itbisval)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.bruto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.cargo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.ddoc)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.pgdo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.otrcargo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<movma>()
                .Property(e => e.ncf)
                .IsUnicode(false);

            modelBuilder.Entity<movma>()
                .Property(e => e.statussync)
                .IsUnicode(false);
        }
    }
}
