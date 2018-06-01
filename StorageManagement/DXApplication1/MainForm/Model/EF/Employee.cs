namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? Gender { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string Regency { get; set; }
    }
}
