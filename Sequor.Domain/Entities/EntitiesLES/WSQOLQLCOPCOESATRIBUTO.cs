namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCOPCOESATRIBUTO")]
    public partial class WSQOLQLCOPCOESATRIBUTO
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ESQUEMA { get; set; }

        [StringLength(50)]
        public string OPCAO { get; set; }

        public bool? OPCAO_OK { get; set; }
    }
}
