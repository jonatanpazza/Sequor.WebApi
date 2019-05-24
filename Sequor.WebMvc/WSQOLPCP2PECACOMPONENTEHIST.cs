namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLPCP2PECACOMPONENTEHIST
    {
        public long ID { get; set; }

        public long? ID_COMPONENTE { get; set; }

        [StringLength(50)]
        public string CODIGO_PECA { get; set; }

        [StringLength(100)]
        public string DESCRICAO_COMPONENTE { get; set; }

        public int? TIPO { get; set; }

        public bool? ATIVO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
