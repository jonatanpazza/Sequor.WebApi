namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIODEFINICOES
    {
        [Key]
        public long ID_DEFINICAO { get; set; }

        public long ID_INVENTARIO { get; set; }

        public long ID_INVENTARIO_ITEM { get; set; }

        public Guid NUMERO_PUBLICACAO { get; set; }

        [Required]
        [StringLength(10)]
        public string NUMERO_INVENTARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Required]
        [StringLength(10)]
        public string DEPOSITO { get; set; }

        public int? QTD_CONTAGENS_OK { get; set; }

        public bool? ESTRATEGIA_ESTOQUE_ATUAL { get; set; }

        public bool? ESTRATEGIA_LOCAL_FIXO { get; set; }

        public bool? ESTRATEGIA_HISTORICO_MOVIMENTACAO { get; set; }

        public bool? ESTRATEGIA_OPS_EM_PROCESSO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public DateTime? ESTRATEGIA_HIST_MOV_DATA_INF { get; set; }

        public DateTime? ESTRATEGIA_HIST_MOV_DATA_SUP { get; set; }
    }
}
