namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOLOCAISTAREFAPRODUTOS
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_LOCAL_TAREFA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS_ESTOQUE_LES { get; set; }

        [StringLength(50)]
        public string CODIGO_TAREFA { get; set; }

        [StringLength(50)]
        public string UNIDADE_CONTAGEM { get; set; }

        public bool? OUTROS { get; set; }

        [StringLength(50)]
        public string RECONTAGEM { get; set; }

        [StringLength(50)]
        public string TIPO_ESTOQUE { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }
    }
}
