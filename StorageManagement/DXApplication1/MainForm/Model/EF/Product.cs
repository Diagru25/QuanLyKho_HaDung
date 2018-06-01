namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public long? UserID { get; set; }

        public long? TypeProductID { get; set; }
    }
}
