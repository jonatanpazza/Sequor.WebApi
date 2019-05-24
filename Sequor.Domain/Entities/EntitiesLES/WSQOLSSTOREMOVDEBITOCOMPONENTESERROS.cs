namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLSSTOREMOVDEBITOCOMPONENTESERROS
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        public long? ID_ESTACAO_STATUS_OP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string OPERACAO { get; set; }

        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ESTACAO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CODIGO_COMPONENTE { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal QUANTIDADE_FALTANTE { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal QUANTIDADE_PRODUZIDA { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string TIPO_MOVIMENTO { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string LOCAL_DEBITO_PADRAO_LES { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string LOCAL_FILTRO_DEBITO_LES { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string CODIGO_RESTRICAO_MOV { get; set; }

        [StringLength(50)]
        public string LOCAL_ERRO { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string ACAO { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool ESTORNADO { get; set; }

        [StringLength(4000)]
        public string MENSAGEM_ERRO { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime DATA_OCORRENCIA { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string USUARIO { get; set; }
    }
}
