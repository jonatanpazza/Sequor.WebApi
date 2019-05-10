namespace Sequor.WebMvc
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StaraContext : DbContext
    {
        public StaraContext()
            : base("name=StaraContext")
        {
        }

        public virtual DbSet<WSQOLCLIENTE> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CODIGO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.NOME_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.GRUPO_CONTAS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CODIGO_CLIENTE_ANTIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ENDERECO_EMISSOR_ORDEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ENDERECO_RECEB_MERCADORIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ENDERECO_RECEB_FATURA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CNPJ_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.NOME_VENDEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.TIPO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ESTADO)
                .IsFixedLength();

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.PAIS_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.RUA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.COD_IDIOMA_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.DESC_COD_IDIOMA_CLIENTE)
                .IsUnicode(false);
        }
    }
}
