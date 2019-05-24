namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLSPEDIDOVENDACGI")]
    public partial class WSQOLSPEDIDOVENDACGI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO_PEDIDO { get; set; }

        public int TIPO_PEDIDO { get; set; }

        public int? ID_JSON { get; set; }

        public DateTime? DATA_REGISTRO { get; set; }

        public int? CODIGO_EMPRESA { get; set; }

        public int? CODIGO_FILIAL { get; set; }

        [StringLength(100)]
        public string SERIE_PEDIDO { get; set; }

        public int? COD_CLI { get; set; }

        [StringLength(50)]
        public string SITUACAO { get; set; }

        [StringLength(100)]
        public string USUARIO { get; set; }

        [StringLength(100)]
        public string CODIGO_FUNCIONARIO { get; set; }

        [StringLength(200)]
        public string NOME_TRANSPORTADORA { get; set; }

        [StringLength(200)]
        public string NOME_CLIENTE { get; set; }

        [StringLength(200)]
        public string NOME_CIDADE_CLIENTE { get; set; }

        public int? CODIGO_VENDEDOR { get; set; }

        [StringLength(200)]
        public string NOME_VENDEDOR { get; set; }

        public int? CODIGO_REGIAO { get; set; }

        [StringLength(200)]
        public string NOME_REGIAO { get; set; }
    }
}
