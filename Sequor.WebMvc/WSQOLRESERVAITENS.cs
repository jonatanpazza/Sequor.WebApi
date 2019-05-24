namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLRESERVAITENS
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_RESERVA { get; set; }

        public long? ID_ITEM { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA { get; set; }

        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [StringLength(50)]
        public string LOCAL_RETIRADA { get; set; }

        public DateTime? DATA_CRIACAO { get; set; }

        public DateTime? DATA_NECESSIDADE { get; set; }

        [StringLength(10)]
        public string TIPO_MOVIMENTO { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string RECEBEDOR { get; set; }

        [StringLength(50)]
        public string CCUSTO { get; set; }

        [StringLength(50)]
        public string PONTO_DESCARGA { get; set; }

        [StringLength(100)]
        public string TEXTO { get; set; }
    }
}
