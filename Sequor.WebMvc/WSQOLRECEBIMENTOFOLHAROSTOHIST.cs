namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOFOLHAROSTOHIST")]
    public partial class WSQOLRECEBIMENTOFOLHAROSTOHIST
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CODIGO_RECEBIMENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ID { get; set; }

        public int? STATUS { get; set; }

        [StringLength(200)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public long ID_FOLHA_ROSTO { get; set; }

        [StringLength(50)]
        public string VERSION_MODULO { get; set; }
    }
}
