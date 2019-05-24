namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANIDENTIFICACAOPICKING")]
    public partial class WSQOLKANBANIDENTIFICACAOPICKING
    {
        public long ID { get; set; }

        public long? ID_SEQ { get; set; }

        public long? ID_KANBAN_DEF { get; set; }

        public DateTime? DATA_GERACAO { get; set; }
    }
}
