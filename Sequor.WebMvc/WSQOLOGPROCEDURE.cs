namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLOGPROCEDURE")]
    public partial class WSQOLOGPROCEDURE
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string CALLER { get; set; }

        [StringLength(500)]
        public string LOG_MESSAGE { get; set; }

        public DateTime? DATE { get; set; }
    }
}
