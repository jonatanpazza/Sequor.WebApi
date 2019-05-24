namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOPORTARIA")]
    public partial class WSQOLRECEBIMENTOPORTARIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PORTARIA { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
