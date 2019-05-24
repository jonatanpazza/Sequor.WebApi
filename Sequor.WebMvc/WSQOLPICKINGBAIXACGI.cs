namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGBAIXACGI")]
    public partial class WSQOLPICKINGBAIXACGI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO_PEDIDO { get; set; }

        public DateTime? DATA_REGISTRO { get; set; }

        [StringLength(200)]
        public string USUARIO { get; set; }

        public int? ERRO { get; set; }

        [StringLength(100)]
        public string MENSAGEM { get; set; }

        public int? TENTATIVAS { get; set; }

        public DateTime? DATA_ULTIMA_TENTATIVA { get; set; }
    }
}
