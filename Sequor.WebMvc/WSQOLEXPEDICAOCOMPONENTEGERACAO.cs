namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOCOMPONENTEGERACAO")]
    public partial class WSQOLEXPEDICAOCOMPONENTEGERACAO
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string MATERIAL { get; set; }

        [StringLength(100)]
        public string COMPONENTE { get; set; }

        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        public DateTime? DATA_IMPRESSAO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string NUMERO_SERIE { get; set; }
    }
}
