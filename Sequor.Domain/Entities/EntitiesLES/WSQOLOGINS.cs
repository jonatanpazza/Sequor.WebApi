namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLOGINS
    {
        [Key]
        [StringLength(20)]
        public string USUARIO { get; set; }

        [StringLength(100)]
        public string SENHA { get; set; }

        [StringLength(50)]
        public string NOME_USUARIO { get; set; }

        public int? TIPO_USUARIO { get; set; }

        [StringLength(50)]
        public string PERFIL { get; set; }

        public bool? HABILITADO { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public DateTime? DATA_CADASTRO { get; set; }

        public int? AUTORIZACAO { get; set; }

        [StringLength(50)]
        public string CELULAR { get; set; }

        public byte[] FOTO { get; set; }

        public int? SPID { get; set; }
    }
}
