namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTODIVERGENCIAITENSACAO")]
    public partial class WSQOLRECEBIMENTODIVERGENCIAITENSACAO
    {
        [Key]
        public byte CODIGO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
