namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLLOCAISROTAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_LOCAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_LOCAL_ROTA { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(50)]
        public string LOCAL_FISICO { get; set; }

        [StringLength(100)]
        public string ENDERECO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? SEQUENCIA { get; set; }

        public int? NIVEL { get; set; }
    }
}
