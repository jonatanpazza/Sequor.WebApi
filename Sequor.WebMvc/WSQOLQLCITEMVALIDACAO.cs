namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCITEMVALIDACAO")]
    public partial class WSQOLQLCITEMVALIDACAO
    {
        public long ID { get; set; }

        public long ID_ITEM { get; set; }

        public long? ID_VALIDACAO { get; set; }

        public virtual WSQOLQLCPLANOITEM WSQOLQLCPLANOITEM { get; set; }
    }
}
