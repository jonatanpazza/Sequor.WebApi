namespace Sequor.Domain.Entities.EntitiesLES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOFOLHAROSTO")]
    public partial class WSQOLRECEBIMENTOFOLHAROSTO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOCAL_CONFERENCIA { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public long? SEQUENCIA { get; set; }

        public DateTime? DATA_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public int? PORTARIA { get; set; }

        [StringLength(100)]
        public string MOTORISTA { get; set; }

        [StringLength(50)]
        public string RG { get; set; }

        [StringLength(50)]
        public string PLACA { get; set; }

        public int? CODIGO_VEICULO { get; set; }

        public int? STATUS { get; set; }

        public bool? SAIDA_VEICULO { get; set; }

        public DateTime? DATA_SAIDA_VEICULO { get; set; }

        [StringLength(50)]
        public string TRANSPORTADORA { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        public long ID_CARGA { get; set; }

        public long ID_RECEBIMENTO_ERP { get; set; }

        public long ID_NF { get; set; }
    }
}
