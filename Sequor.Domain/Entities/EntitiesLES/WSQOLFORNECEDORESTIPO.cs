namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLFORNECEDORESTIPO")]
    public partial class WSQOLFORNECEDORESTIPO
    {
        [Key]
        [StringLength(10)]
        public string TIPO_FORNECEDOR { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
