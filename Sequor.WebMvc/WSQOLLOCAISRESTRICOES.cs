namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLLOCAISRESTRICOES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_RESTRICAO { get; set; }

        public bool? APLICAR_LOCAIS_FILHOS { get; set; }
    }
}
