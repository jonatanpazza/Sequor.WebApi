namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANSEMDEF")]
    public partial class WSQOLKANBANSEMDEF
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        [StringLength(50)]
        public string OPERACAO { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        public int? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string KIT { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }
    }
}
