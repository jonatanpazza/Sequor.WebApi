namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINHAMONTAGEM")]
    public partial class WSQOLINHAMONTAGEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ESTACAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_LINHA_MONTAGEM { get; set; }

        [StringLength(100)]
        public string DESCRICAO_ESTACAO { get; set; }

        public int? TIPO_ESTACAO { get; set; }

        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [StringLength(100)]
        public string ESQUEMA_PRODUCAO { get; set; }

        public bool? JUSTIFICA_PARADA { get; set; }
    }
}
