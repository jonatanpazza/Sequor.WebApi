namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLPRERECEBIMENTOVOLUMES
    {
        public long ID { get; set; }

        public int? CODIGO_RECEBIMENTO { get; set; }

        [StringLength(50)]
        public string CODIGO_VOLUME { get; set; }

        public int? SEQUENCIA { get; set; }

        public int? ID_NF { get; set; }

        [StringLength(50)]
        public string ESPECIE { get; set; }

        [StringLength(10)]
        public string NUMERO_LOCAL { get; set; }

        public bool? VERIFICADO { get; set; }
    }
}
