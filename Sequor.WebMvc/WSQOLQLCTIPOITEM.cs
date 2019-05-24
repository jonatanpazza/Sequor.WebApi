namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCTIPOITEM")]
    public partial class WSQOLQLCTIPOITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_TIPO_ITEM { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(100)]
        public string CAMPO_1 { get; set; }

        [StringLength(100)]
        public string CAMPO_2 { get; set; }

        [StringLength(100)]
        public string CAMPO_3 { get; set; }
    }
}
