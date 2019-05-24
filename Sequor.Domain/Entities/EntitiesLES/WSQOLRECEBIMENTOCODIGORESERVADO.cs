namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOCODIGORESERVADO")]
    public partial class WSQOLRECEBIMENTOCODIGORESERVADO
    {
        [Key]
        public long ID_RECEBIMENTO { get; set; }

        [StringLength(100)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }
    }
}
