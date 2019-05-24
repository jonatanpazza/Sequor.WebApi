namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOITEMREMESSAVOLUME")]
    public partial class WSQOLEXPEDICAOITEMREMESSAVOLUME
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_EXP_REMESSA_ITENS { get; set; }

        public long? ID_EXPEDICAO_VOLUME { get; set; }

        [StringLength(50)]
        public string ITEM_REMESSA { get; set; }
    }
}
