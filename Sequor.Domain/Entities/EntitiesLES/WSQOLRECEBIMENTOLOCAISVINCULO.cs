namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOLOCAISVINCULO")]
    public partial class WSQOLRECEBIMENTOLOCAISVINCULO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOCAL_CONFERENCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOCAL_ENTREGA { get; set; }

        public int? PRIORIDADE { get; set; }
    }
}
