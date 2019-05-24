namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLMOTORISTAS
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_MOTORISTA { get; set; }

        [StringLength(10)]
        public string RG_MOTORISTA { get; set; }

        [StringLength(50)]
        public string CPF_MOTORISTA { get; set; }

        [StringLength(50)]
        public string TRANSPORTADORA { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string TELEFONE { get; set; }

        [StringLength(20)]
        public string CELULAR { get; set; }

        public bool? HABILITADO { get; set; }
    }
}
