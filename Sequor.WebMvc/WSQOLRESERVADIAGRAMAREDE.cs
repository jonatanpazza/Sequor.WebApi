namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRESERVADIAGRAMAREDE")]
    public partial class WSQOLRESERVADIAGRAMAREDE
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [StringLength(50)]
        public string DIAGRAMA_REDE { get; set; }

        [StringLength(50)]
        public string RESERVA { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        [StringLength(50)]
        public string ELEMENTO_PEP { get; set; }

        [StringLength(50)]
        public string CODIGO_LOTE { get; set; }

        [StringLength(50)]
        public string MATERIAL { get; set; }
    }
}
