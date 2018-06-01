namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
    }
}
