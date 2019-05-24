namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSAITENSNRSERIECOMPONENTE")]
    public partial class WSQOLEXPREMESSAITENSNRSERIECOMPONENTE
    {
        public long ID { get; set; }

        public long? ID_REMESSA { get; set; }

        public long? ID_REMESSA_ITEM { get; set; }

        public long? ID_REMESSA_ITEM_NR_SERIE { get; set; }

        public long? ID_SEQ { get; set; }

        public long? ID_SEQ_ITEM { get; set; }

        [StringLength(50)]
        public string NR_SERIE { get; set; }

        [StringLength(50)]
        public string CODIGO_COMPONENTE { get; set; }

        [StringLength(50)]
        public string DESCRICAO_COMPONENTE { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
