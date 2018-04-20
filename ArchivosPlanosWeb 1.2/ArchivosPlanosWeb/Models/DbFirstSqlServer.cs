namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbFirstSqlServer : DbContext
    {
        public DbFirstSqlServer()
            : base("name=SqlServerConnection")
        {
        }

        public virtual DbSet<TYPE_OPERADORES> TYPE_OPERADORES { get; set; }
        public virtual DbSet<TYPE_PLAZA> TYPE_PLAZA { get; set; }
        public virtual DbSet<TYPE_TRAMO> TYPE_TRAMO { get; set; }
        public virtual DbSet<TYPE_CARRIL> TYPE_CARRIL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TYPE_OPERADORES>()
                .Property(e => e.numGea)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OPERADORES>()
                .Property(e => e.numCapufe)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PLAZA>()
                .Property(e => e.idPlaza)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PLAZA>()
                .Property(e => e.nomPlaza)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PLAZA>()
                .Property(e => e.idTramo)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PLAZA>()
                .HasMany(e => e.TYPE_CARRIL)
                .WithRequired(e => e.TYPE_PLAZA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYPE_TRAMO>()
                .Property(e => e.idTramo)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_TRAMO>()
                .Property(e => e.nomTramo)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_TRAMO>()
                .HasMany(e => e.TYPE_PLAZA)
                .WithRequired(e => e.TYPE_TRAMO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYPE_CARRIL>()
                .Property(e => e.idCarril)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CARRIL>()
                .Property(e => e.numCarril)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CARRIL>()
                .Property(e => e.idPlaza)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CARRIL>()
                .Property(e => e.numTramo)
                .IsUnicode(false);
        }
    }
}
