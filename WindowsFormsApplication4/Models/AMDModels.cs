namespace AMDManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AMDModels : DbContext
    {
        public AMDModels()
            : base("name=AMDModels")
        {
        }

        public virtual DbSet<Arquivo> Arquivoes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Comerciai> Comerciais { get; set; }
        public virtual DbSet<Distancia> Distancias { get; set; }
        public virtual DbSet<Encomenda> Encomendas { get; set; }
        public virtual DbSet<EncomendasAttalen> EncomendasAttalens { get; set; }
        public virtual DbSet<EncomendasFrita> EncomendasFritas { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Palete> Paletes { get; set; }
        public virtual DbSet<PlanoSemanal> PlanoSemanals { get; set; }
        public virtual DbSet<Preco> Precos { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Transportadora> Transportadoras { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.EncomendasFritas)
                .WithOptional(e => e.Cliente1)
                .HasForeignKey(e => e.Cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Encomendas)
                .WithRequired(e => e.Cliente1)
                .HasForeignKey(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comerciai>()
                .HasMany(e => e.PlanoSemanals)
                .WithOptional(e => e.Comerciai)
                .HasForeignKey(e => e.Comercial);

            modelBuilder.Entity<Distancia>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.Distancia)
                .HasForeignKey(e => e.Opcao_zona_2);

            modelBuilder.Entity<Distancia>()
                .HasMany(e => e.Clientes1)
                .WithOptional(e => e.Distancia1)
                .HasForeignKey(e => e.Opcao_zona_3);

            modelBuilder.Entity<Distancia>()
                .HasMany(e => e.Clientes2)
                .WithRequired(e => e.Distancia2)
                .HasForeignKey(e => e.Zona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Distancia>()
                .HasMany(e => e.Precos)
                .WithRequired(e => e.Distancia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Encomenda>()
                .Property(e => e.CodEncomenda)
                .IsFixedLength();

            modelBuilder.Entity<Encomenda>()
                .HasMany(e => e.EncomendasFritas)
                .WithOptional(e => e.Encomenda1)
                .HasForeignKey(e => e.Encomenda);

            modelBuilder.Entity<EncomendasAttalen>()
                .Property(e => e.CodEncomenda)
                .IsFixedLength();

            modelBuilder.Entity<EncomendasFrita>()
                .Property(e => e.Encomenda)
                .IsFixedLength();

            modelBuilder.Entity<PlanoSemanal>()
                .HasMany(e => e.EncomendasFritas)
                .WithOptional(e => e.PlanoSemanal)
                .HasForeignKey(e => e.Plano);

            modelBuilder.Entity<Table>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.CodEncomenda)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.Peso)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.Encomendas)
                .WithOptional(e => e.Transportadora1)
                .HasForeignKey(e => e.Transportadora);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.PlanoSemanals)
                .WithOptional(e => e.Transportadora)
                .HasForeignKey(e => e.Transportador);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.Precos)
                .WithRequired(e => e.Transportadora1)
                .HasForeignKey(e => e.transportadora)
                .WillCascadeOnDelete(false);
        }
    }
}
