namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO")]
    public partial class WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        [StringLength(50)]
        public string OPERACAO { get; set; }

        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }

        [StringLength(50)]
        public string ESTACAO { get; set; }

        [StringLength(50)]
        public string CODIGO_COMPONENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string TIPO_MOVIMENTO { get; set; }

        [StringLength(50)]
        public string LOCAL_DEBITO_PADRAO_LES { get; set; }

        [StringLength(50)]
        public string LOCAL_FILTRO_DEBITO_LES { get; set; }

        [StringLength(50)]
        public string CODIGO_RESTRICAO_MOV { get; set; }

        [StringLength(50)]
        public string LOCAL_ERRO { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(10)]
        public string ACAO { get; set; }

        public bool? ESTORNADO { get; set; }

        [StringLength(4000)]
        public string MENSAGEM_ERRO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public int? STATUS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string USUARIO { get; set; }
    }
}
