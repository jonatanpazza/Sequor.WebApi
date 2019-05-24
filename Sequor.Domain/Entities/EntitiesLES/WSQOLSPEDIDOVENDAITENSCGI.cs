namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLSPEDIDOVENDAITENSCGI")]
    public partial class WSQOLSPEDIDOVENDAITENSCGI
    {
        [Key]
        public int ID_ITEMPEDIDO { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        public int CODIGO_PEDIDO { get; set; }

        public DateTime DATA_REGISTRO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string VALOR_UNITARIO { get; set; }

        [StringLength(50)]
        public string QUANTIDADE_AUTORIZADA { get; set; }
    }
}
