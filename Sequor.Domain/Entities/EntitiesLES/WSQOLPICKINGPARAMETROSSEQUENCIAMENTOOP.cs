namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP")]
    public partial class WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_SEQ { get; set; }

        public DateTime? DATA_SEPARACAO { get; set; }

        public DateTime? DATA_SEPARACAO_TERMINO { get; set; }

        public DateTime? DATA_PROCESSO_INICIO { get; set; }

        public DateTime? DATA_PROCESSO_FIM { get; set; }

        [StringLength(50)]
        public string CENTRO_TRABALHO { get; set; }

        [StringLength(50)]
        public string OPERACAO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(100)]
        public string DOC_REFERENCIA { get; set; }
    }
}
