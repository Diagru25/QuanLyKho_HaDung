namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryNoteDetail")]
    public partial class DeliveryNoteDetail
    {
        public long ID { get; set; }

        public long? DeliveryNoteID { get; set; }

        public long? MaterialID { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }
    }
}
