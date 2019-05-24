namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLPCP2PECACOMPONENTE
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PECA { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO_COMPONENTE { get; set; }

        public int TIPO { get; set; }

        public bool? ATIVO { get; set; }
    }
}
