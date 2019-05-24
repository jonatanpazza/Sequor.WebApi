namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLHELPHTML")]
    public partial class WSQOLHELPHTML
    {
        [Key]
        [StringLength(100)]
        public string ID_HELP { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public string HTML_HELP { get; set; }
    }
}
