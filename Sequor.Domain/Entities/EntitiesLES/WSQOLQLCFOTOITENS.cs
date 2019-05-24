namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLQLCFOTOITENS
    {
        public long ID { get; set; }

        public long ID_FOTO { get; set; }

        public byte[] STREAM { get; set; }
    }
}
