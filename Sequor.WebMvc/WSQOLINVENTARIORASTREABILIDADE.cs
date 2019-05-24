namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIORASTREABILIDADE")]
    public partial class WSQOLINVENTARIORASTREABILIDADE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_STATUS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string NUMERO_SERIE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        public DateTime? DATA_OCORRENCIA_INICIAL { get; set; }

        public DateTime? DATA_OCORRENCIA_FINAL { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public bool? CONTAGEM_FINAL_OK { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_TAREFA_PRODUTOS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public int? STATUS { get; set; }
    }
}
