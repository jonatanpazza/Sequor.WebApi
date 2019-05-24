namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLFORNECEDORES
    {
        [Key]
        public int ID_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string RAZAO_SOCIAL { get; set; }

        [StringLength(50)]
        public string NOME_FORNECEDOR { get; set; }

        [StringLength(10)]
        public string TIPO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string CIDADE { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string PAIS { get; set; }

        [StringLength(50)]
        public string CPF_CNPJ { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        [StringLength(50)]
        public string SITE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string TELEFONE { get; set; }

        [StringLength(20)]
        public string CELULAR { get; set; }

        public bool? HABILITADO { get; set; }
    }
}
