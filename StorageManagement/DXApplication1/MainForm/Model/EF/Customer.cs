namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }
    }
}
