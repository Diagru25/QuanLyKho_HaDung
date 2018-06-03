using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.View
{
    public class ReportView
    {
        public long? MaterialID { get; set; }
        public long? StorageID { get; set; }
        public string MaterialName { get; set; }
        public int? TonDauKy { get; set; }
        public int? Nhap { get; set; }
        public int? Xuat { get; set; }
        public int? TonCuoiKy { get; set; }
    }
}
