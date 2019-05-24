namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLRECEBIMENTOVOLUMESITENS
    {
        public long ID { get; set; }

        public long ID_RECEBIMENTO_VOLUMES { get; set; }

        public long ID_RECEBIMENTO_ERP_ITENS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QUANTIDADE_VINCULADA { get; set; }
    }
}
