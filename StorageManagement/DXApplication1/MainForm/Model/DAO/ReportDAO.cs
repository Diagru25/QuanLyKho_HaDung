using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;
using MainForm.Model.View;

namespace MainForm.Model.DAO
{
    public class ReportDAO
    {
        QLKDbContext db = null;
        public ReportDAO()
        {
            db = new QLKDbContext();
        }
        public List<ReportView> Report(DateTime _start, DateTime _end, long StorageID)
        {
            List<Material> material = db.Materials.ToList();
            List<ReportView> result = new List<ReportView>();
            ReportView temp = new ReportView();
            temp.StorageID = StorageID;
            foreach (var item in material)
            {
                temp.MaterialID = item.ID;
                temp.MaterialName = item.Name;

                if (StorageID != 0)
                {
                    temp.TonDauKy = (from a in db.ReceiptNotes
                                     join b in db.ReceiptNoteDetails on a.ID equals b.ReceiptNoteID
                                     where a.StorageID == StorageID && b.MaterialID == item.ID && a.ReceiptDate < _start
                                     select b.Quantity).Sum() - (from a in db.DeliveryNotes
                                                                 join b in db.DeliveryNoteDetails on a.ID equals b.DeliveryNoteID
                                                                 where a.StorageID == StorageID && b.MaterialID == item.ID && a.DeliveryDate < _start
                                                                 select b.Quantity).Sum();
                    temp.Xuat = (from a in db.DeliveryNotes
                                 join b in db.DeliveryNoteDetails on a.ID equals b.DeliveryNoteID
                                 where a.StorageID == StorageID && b.MaterialID == item.ID && a.DeliveryDate >= _start && a.DeliveryDate <= _end
                                 select b.Quantity).Sum();
                    temp.Nhap = (from a in db.ReceiptNotes
                                 join b in db.ReceiptNoteDetails on a.ID equals b.ReceiptNoteID
                                 where a.StorageID == StorageID && b.MaterialID == item.ID && a.ReceiptDate >= _start && a.ReceiptDate <= _end
                                 select b.Quantity).Sum();                    
                }
                else
                {
                    temp.TonDauKy = (from a in db.ReceiptNotes
                                     join b in db.ReceiptNoteDetails on a.ID equals b.ReceiptNoteID
                                     where b.MaterialID == item.ID && a.ReceiptDate < _start
                                     select b.Quantity).Sum() - (from a in db.DeliveryNotes
                                                                 join b in db.DeliveryNoteDetails on a.ID equals b.DeliveryNoteID
                                                                 where b.MaterialID == item.ID && a.DeliveryDate < _start
                                                                 select b.Quantity).Sum();
                    temp.Xuat = (from a in db.DeliveryNotes
                                 join b in db.DeliveryNoteDetails on a.ID equals b.DeliveryNoteID
                                 where b.MaterialID == item.ID && a.DeliveryDate >= _start && a.DeliveryDate <= _end
                                 select b.Quantity).Sum();
                    temp.Nhap = (from a in db.ReceiptNotes
                                 join b in db.ReceiptNoteDetails on a.ID equals b.ReceiptNoteID
                                 where b.MaterialID == item.ID && a.ReceiptDate >= _start && a.ReceiptDate <= _end
                                 select b.Quantity).Sum();
                }
                temp.TonCuoiKy = temp.TonDauKy + temp.Nhap + temp.Xuat;

                result.Add(temp);
            }
            return result;
        }
    }
}
