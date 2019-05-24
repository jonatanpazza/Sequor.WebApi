namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANATUAL")]
    public partial class WSQOLKANBANATUAL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_KANBAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_CARTAO { get; set; }

        [StringLength(50)]
        public string LOCAL_RECIPIENTE { get; set; }

        [StringLength(50)]
        public string LOCAL_ALOCACAO { get; set; }

        public int? STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_ATUAL { get; set; }

        public DateTime? DATA_CRIACAO { get; set; }

        public DateTime? DATA_ULTIMA_MODIFICACAO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
    }
}
