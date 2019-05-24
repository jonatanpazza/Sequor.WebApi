namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOTIPOESTOQUE")]
    public partial class WSQOLINVENTARIOTIPOESTOQUE
    {
        public long ID { get; set; }

        public int? TIPO_ESTOQUE_INVENTARIO_ERP { get; set; }

        public int? TIPO_ESTOQUE_LES { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? STATUS { get; set; }
    }
}
