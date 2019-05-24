namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLCODBLOQUEIOESTOQUEITEM")]
    public partial class WSQOLCODBLOQUEIOESTOQUEITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_BLOQUEIO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_BLOQUEIO { get; set; }

        [Required]
        [StringLength(100)]
        public string MENSAGEM { get; set; }

        [Required]
        [StringLength(50)]
        public string COR { get; set; }

        [Required]
        [StringLength(50)]
        public string COR_HEXA { get; set; }

        [StringLength(3)]
        public string LABEL { get; set; }

        [StringLength(50)]
        public string COR_ITEM_SELECIONADO { get; set; }
    }
}
