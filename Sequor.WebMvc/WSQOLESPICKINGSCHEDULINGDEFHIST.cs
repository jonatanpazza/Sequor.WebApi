namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLESPICKINGSCHEDULINGDEFHIST")]
    public partial class WSQOLESPICKINGSCHEDULINGDEFHIST
    {
        [Key]
        public long ID_HIST { get; set; }

        public long ID_DEF { get; set; }

        [StringLength(50)]
        public string ORIGEM { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string CLIENTE { get; set; }

        public int? HABILITADO { get; set; }

        public int? TEMPO_TOLERANCIA_PAGAMENTO_SEGUNDOS { get; set; }

        public int? TEMPO_PADRAO_PAGAMENTO_SEGUNDOS { get; set; }

        public int? TEMPO_PADRAO_ENTREGA_SEGUNDOS { get; set; }

        public int? GATILHOS { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_ALTERACAO { get; set; }

        public DateTime? DATA_ULTIMA_ALTERACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
