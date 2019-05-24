namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSAITENSSTATUSTIPO")]
    public partial class WSQOLEXPREMESSAITENSSTATUSTIPO
    {
        public long ID { get; set; }

        public int? STATUS { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string COR { get; set; }

        [StringLength(50)]
        public string COR_HEXA { get; set; }

        [StringLength(50)]
        public string COR_ITEM_SELECIONADO { get; set; }

        [StringLength(3)]
        public string LABEL { get; set; }
    }
}
