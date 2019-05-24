namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCPLANOITEM")]
    public partial class WSQOLQLCPLANOITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSQOLQLCPLANOITEM()
        {
            WSQOLQLCITEMVALIDACAO = new HashSet<WSQOLQLCITEMVALIDACAO>();
        }

        public long ID { get; set; }

        public int ID_PLANO_QUALIDADE { get; set; }

        public int SEQUENCIA { get; set; }

        [StringLength(500)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string REGRA { get; set; }

        public int? TIPO_ITEM { get; set; }

        [StringLength(100)]
        public string DISPOSITIVO_COLETA { get; set; }

        public bool? COLETA_COMPONENTE { get; set; }

        [StringLength(100)]
        public string CODIGO_COMPONENTE { get; set; }

        public int? TIPO_DADO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LIMITE_INFERIOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LIMITE_SUPERIOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NOMINAL { get; set; }

        [StringLength(10)]
        public string UNIDADE { get; set; }

        [StringLength(100)]
        public string GED_VIRTUAL_FOLDER { get; set; }

        public int? TIPO_FOTO { get; set; }

        [StringLength(100)]
        public string OPCOES_ATRIBUTO { get; set; }

        public bool? ATRIBUTO_LIVRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WSQOLQLCITEMVALIDACAO> WSQOLQLCITEMVALIDACAO { get; set; }
    }
}
