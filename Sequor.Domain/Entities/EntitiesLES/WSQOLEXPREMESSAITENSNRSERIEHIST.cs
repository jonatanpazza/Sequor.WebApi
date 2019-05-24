namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSAITENSNRSERIEHIST")]
    public partial class WSQOLEXPREMESSAITENSNRSERIEHIST
    {
        public long ID { get; set; }

        public long? ID_NR_SERIE { get; set; }

        public long? ID_REMESSA_ITEM { get; set; }

        [StringLength(50)]
        public string NR_SERIE { get; set; }

        public int? STATUS { get; set; }

        public long? ID_REMESSA { get; set; }

        [StringLength(50)]
        public string CODIGO_REMESSA { get; set; }

        [StringLength(50)]
        public string ITEM_REMESSA { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
