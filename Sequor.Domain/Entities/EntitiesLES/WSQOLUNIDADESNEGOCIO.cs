namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLUNIDADESNEGOCIO")]
    public partial class WSQOLUNIDADESNEGOCIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_UNIDADE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOCAL_INTEGRACAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_LOCAL { get; set; }

        public bool? HABILITADO { get; set; }
    }
}
