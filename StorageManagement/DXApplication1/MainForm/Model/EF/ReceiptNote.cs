namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptNote")]
    public partial class ReceiptNote
    {
        public long ID { get; set; }

        public long? StorageID { get; set; }

        public long ? EmployeeID { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }
        public Decimal? Amount { get; set; }
    }
}
