namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRESTRICOESDEF")]
    public partial class WSQOLRESTRICOESDEF
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_RESTRICAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(200)]
        public string DESCRICAO_LONGA { get; set; }

        public bool? BLOQUEAR_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string PROCEDURE_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string PROCEDURE_SUGESTAO_ALOCACAO { get; set; }

        [StringLength(50)]
        public string PROCEDURE_SUGESTAO_RETIRADA { get; set; }

        public bool? HABILITADO { get; set; }

        [Column(TypeName = "xml")]
        public string PARAMETROS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_SUGESTAO_ALOCACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_SUGESTAO_RETIRADA { get; set; }

        public int? PRIORIDADE_SUGESTAO_ALOCACAO { get; set; }

        public int? PRIORIDADE_SUGESTAO_RETIRADA { get; set; }
    }
}
