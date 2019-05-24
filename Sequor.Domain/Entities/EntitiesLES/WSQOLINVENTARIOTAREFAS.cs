namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOTAREFAS
    {
        [Key]
        public long ID_TAREFA { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        public int TIPO_ESTOQUE_LES { get; set; }

        public long? ID_INVENTARIO { get; set; }

        public long ID_ITEM_INVENTARIO { get; set; }

        [StringLength(10)]
        public string NUMERO_INVENTARIO { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(10)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string UNIDADE_CONTAGEM { get; set; }

        public int? TIPO_TAREFA { get; set; }

        [StringLength(50)]
        public string ESTRATEGIA { get; set; }

        public DateTime? DATA_GERACAO { get; set; }

        public int? QTD_CONTAGENS_OK { get; set; }

        public Guid GRUPO_CRIACAO { get; set; }

        public int TIPO_INVENTARIO { get; set; }

        public int? TIPO_AUDITORIA { get; set; }
    }
}
