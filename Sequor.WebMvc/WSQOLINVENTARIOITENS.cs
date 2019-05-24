namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOITENS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_INVENTARIO_ITEM { get; set; }

        public long ID_INVENTARIO { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ITEM_INVENTARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NUMERO_INVENTARIO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPO_ESTOQUE_LES { get; set; }

        [Required]
        [StringLength(50)]
        public string UNIDADE_MEDIDA { get; set; }

        [StringLength(50)]
        public string DOC_RECONTAGEM { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string ESTOQUE_ESPECIAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string CONTAGEM_ZERO { get; set; }

        [StringLength(50)]
        public string CONTADO { get; set; }

        [StringLength(50)]
        public string CONTAGEM_APROVADA { get; set; }

        [StringLength(50)]
        public string RECONTAGEM { get; set; }

        [StringLength(50)]
        public string ITEM_ELIMINADO { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        public int TIPO_INVENTARIO { get; set; }

        [StringLength(50)]
        public string LOCAL { get; set; }

        [StringLength(50)]
        public string ORDEM_CLIENTE { get; set; }

        public int? ITEM_ORDEM_CLIENTE { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(50)]
        public string PRIORIDADE { get; set; }
    }
}
