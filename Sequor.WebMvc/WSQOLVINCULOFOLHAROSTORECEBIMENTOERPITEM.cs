namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLVINCULOFOLHAROSTORECEBIMENTOERPITEM")]
    public partial class WSQOLVINCULOFOLHAROSTORECEBIMENTOERPITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_RECEBIMENTO_ERP_ITEM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_RECEBIMENTO_FOLHA_ROSTO { get; set; }
    }
}
