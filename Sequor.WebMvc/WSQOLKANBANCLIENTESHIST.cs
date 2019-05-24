namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANCLIENTESHIST")]
    public partial class WSQOLKANBANCLIENTESHIST
    {
        [Key]
        public long ID_CLIENTE_HIST { get; set; }

        public long ID_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public long ID_GRUPO { get; set; }

        [StringLength(1)]
        public string OPERACAO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }

        [StringLength(50)]
        public string OS_USER_NAME { get; set; }
    }
}
