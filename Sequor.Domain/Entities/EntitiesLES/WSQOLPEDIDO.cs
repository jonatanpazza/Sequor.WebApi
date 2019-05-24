namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPEDIDO")]
    public partial class WSQOLPEDIDO
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_PEDIDO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_PEDIDO { get; set; }

        [StringLength(50)]
        public string TIPO_PEDIDO { get; set; }

        public DateTime? DATA_ABERTURA_PEDIDO { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        public int? STATUS_PEDIDO { get; set; }

        [StringLength(50)]
        public string CODIGO_COMPRADOR { get; set; }

        [StringLength(100)]
        public string NOME_COMPRADOR { get; set; }

        [StringLength(50)]
        public string CONTATO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string MOEDA { get; set; }

        [StringLength(50)]
        public string USUARIO_CRIACAO { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }

        public DateTime? DATA_ULTIMA_MODIFICACAO { get; set; }
    }
}
