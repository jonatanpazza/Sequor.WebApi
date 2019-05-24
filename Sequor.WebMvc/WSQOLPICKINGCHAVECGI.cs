namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGCHAVECGI")]
    public partial class WSQOLPICKINGCHAVECGI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CGI { get; set; }

        [Required]
        [StringLength(50)]
        public string CHAVE { get; set; }
    }
}
