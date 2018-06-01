namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeProduct")]
    public partial class TypeProduct
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }

        [StringLength(50)]
        public string Faculty { get; set; }
    }
}
