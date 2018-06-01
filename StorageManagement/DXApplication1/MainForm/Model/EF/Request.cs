namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Request")]
    public partial class Request
    {
        public long ID { get; set; }

        public long? EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceivedDate { get; set; }

        public long? StorageID { get; set; }

        public decimal? IntoMoney { get; set; }
    }
}
