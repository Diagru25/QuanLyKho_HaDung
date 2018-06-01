namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryNote")]
    public partial class DeliveryNote
    {
        public long ID { get; set; }

        public long? StorageID { get; set; }

        public long? EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeliveryDate { get; set; }

        public long? CustomerID { get; set; }
    }
}
