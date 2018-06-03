namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptNoteDetail")]
    public partial class ReceiptNoteDetail
    {
        public long ID { get; set; }

        public long? ReceiptNoteID { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }
        public long? MaterialID { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }
    }
}
