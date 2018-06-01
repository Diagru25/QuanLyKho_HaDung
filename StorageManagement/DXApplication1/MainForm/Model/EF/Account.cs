namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        public long? EmployeeID { get; set; }

        public bool? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateData { get; set; }

        public long? PermissionID { get; set; }
    }
}
