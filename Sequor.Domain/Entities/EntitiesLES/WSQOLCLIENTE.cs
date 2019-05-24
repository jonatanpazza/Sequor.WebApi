namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLCLIENTE")]
    public partial class WSQOLCLIENTE
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_CLIENTE { get; set; }

        [StringLength(100)]
        public string NOME_CLIENTE { get; set; }

        [StringLength(50)]
        public string GRUPO_CONTAS { get; set; }

        [StringLength(50)]
        public string CODIGO_CLIENTE_ANTIGO { get; set; }

        [StringLength(50)]
        public string PAIS { get; set; }

        [StringLength(100)]
        public string ENDERECO_EMISSOR_ORDEM { get; set; }

        [StringLength(100)]
        public string ENDERECO_RECEB_MERCADORIA { get; set; }

        [StringLength(100)]
        public string ENDERECO_RECEB_FATURA { get; set; }

        [StringLength(50)]
        public string CNPJ_CLIENTE { get; set; }

        [StringLength(50)]
        public string INSCRICAO_ESTADUAL { get; set; }

        [StringLength(500)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string TELEFONE { get; set; }

        [StringLength(50)]
        public string CELULAR { get; set; }

        [StringLength(100)]
        public string NOME_VENDEDOR { get; set; }

        [StringLength(10)]
        public string TIPO_CLIENTE { get; set; }

        [StringLength(500)]
        public string CIDADE { get; set; }

        [StringLength(10)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string PAIS_DESCRICAO { get; set; }

        [StringLength(50)]
        public string RUA { get; set; }

        [StringLength(50)]
        public string BAIRRO { get; set; }

        [StringLength(50)]
        public string CEP { get; set; }

        [StringLength(50)]
        public string UF { get; set; }

        [StringLength(50)]
        public string COD_IDIOMA_CLIENTE { get; set; }

        [StringLength(50)]
        public string DESC_COD_IDIOMA_CLIENTE { get; set; }
    }
}
