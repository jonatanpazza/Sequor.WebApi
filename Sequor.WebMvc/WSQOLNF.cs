namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLNF")]
    public partial class WSQOLNF
    {
        [Key]
        [StringLength(50)]
        public string CHAVE_NF { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_NF { get; set; }

        public int? NUMERO_NF { get; set; }

        [StringLength(100)]
        public string NATUREZA_OP { get; set; }

        public DateTime? DATA_EMISSAO { get; set; }

        public int? TIPO_NF { get; set; }

        [StringLength(50)]
        public string CPF_CNPJ_FORNECEDOR { get; set; }

        [StringLength(100)]
        public string NOME_FORNECEDOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR_TOTAL { get; set; }

        [StringLength(50)]
        public string CNPJ_TRANSPORTADORA { get; set; }

        [StringLength(100)]
        public string NOME_TRANSPORTADORA { get; set; }

        [StringLength(10)]
        public string PLACA_TRANSPORTADORA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_VOLUMES { get; set; }

        [StringLength(50)]
        public string ESPECIE_VOLUMES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_LIQUIDO_VOLUMES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_BRUTO_VOLUMES { get; set; }

        [StringLength(50)]
        public string PEDIDO_COMPRA { get; set; }

        public bool? NFE { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string CNPJ_DESTINATARIO { get; set; }

        public int? SERIE { get; set; }
    }
}
