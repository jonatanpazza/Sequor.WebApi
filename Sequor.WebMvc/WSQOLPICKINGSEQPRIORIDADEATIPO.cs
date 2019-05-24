namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGSEQPRIORIDADEATIPO")]
    public partial class WSQOLPICKINGSEQPRIORIDADEATIPO
    {
        public long ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_A { get; set; }

        [StringLength(50)]
        public string COR { get; set; }

        [StringLength(50)]
        public string COR_HEXA { get; set; }

        [StringLength(3)]
        public string LABEL { get; set; }

        [StringLength(50)]
        public string COR_ITEM_SELECIONADO { get; set; }

        public int? ORDER_BY { get; set; }
    }
}
