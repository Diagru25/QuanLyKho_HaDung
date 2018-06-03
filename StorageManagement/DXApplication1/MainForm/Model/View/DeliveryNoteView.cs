using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.View
{
    public class DeliveryNoteView
    {
        public long ID { get; set; }
        public long? StorageID { get; set; }
        public string StorageName { get; set; }
        public long? CustomerID { get; set; }
        public string CustomerName { get; set; }
        public long? EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string TrangThai { get; set; }
        public int? Status { get; set; }
        public Decimal? Amount { get; set; }

    }
}
