namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOITENSSTATUS
    {
        public long ID { get; set; }

        public long ID_INVENTARIO_ITEM { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public int? STATUS_ESTOQUE { get; set; }

        public int? TIPO_ESTOQUE_LES { get; set; }

        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        public int? NUMERO_TENTATIVAS { get; set; }
    }
}
