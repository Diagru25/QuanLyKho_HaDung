using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.View
{
    public class DeliveryNoteDetailView
    {
        public long ID { get; set; }
        public long? DeliveryNoteID { get; set; }
        public long? MaterialID { get; set; }
        public string MaterialName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

    }
}
