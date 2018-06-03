using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;
using MainForm.Model.View;

namespace MainForm.Model.DAO
{
    public class ReceiptNoteDAO
    {
        QLKDbContext db = null;
        public ReceiptNoteDAO()
        {
            db = new QLKDbContext();
        }
<<<<<<< HEAD
        #region HG
        public long Insert(ReceiptNote item)
        {
            try
            {
                db.ReceiptNotes.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }
        public bool InsertDetail(ReceiptNoteDetail item)
        {
            try
            {
                db.ReceiptNoteDetails.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteDetail(long id)
        {
            try
            {
                var dbEntry = db.ReceiptNoteDetails.SingleOrDefault(x => x.ID == id);
                db.ReceiptNoteDetails.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ReceiptNoteDetailView> GetDetail(long? id)
        {
            var data = (from a in db.ReceiptNoteDetails
                        join b in db.Materials on a.MaterialID equals b.ID
                        where a.ReceiptNoteID == id
                        select new ReceiptNoteDetailView()
                        {
                            ID = a.ID,
                            ReceiptNoteID = id,
                            MaterialID = a.MaterialID,
                            MaterialName = b.Name,
                            Price = a.Price,
                            Quantity = a.Quantity
                        }).ToList();
            return data;
        }
        public void Amount(long? id)
        {
            var data = db.ReceiptNoteDetails.Where(x => x.ReceiptNoteID == id).ToList();
            Decimal? res = 0;
            foreach (var item in data)
            {
                res += item.Quantity * item.Price;
            }
            var dbEntry = db.ReceiptNotes.SingleOrDefault(x => x.ID == id);
            dbEntry.Amount = res;
            db.SaveChanges();
        }
        public List<ReceiptNoteView> GetNote()
        {
            var data = (from a in db.ReceiptNotes
                        join b in db.Storages on a.StorageID equals b.ID
                        join d in db.Employees on a.EmployeeID equals d.ID
                        select new ReceiptNoteView()
                        {
                            ID = a.ID,
                            StorageID = a.StorageID,
                            StorageName = b.Name,
                            EmployeeID = a.EmployeeID,
                            EmployeeName = d.Name,
                            ReceiptDate = a.ReceiptDate,
                            Status = a.Status,
                            Amount = a.Amount
                        }).ToList();
            foreach (var item in data)
            {
                if (item.Status == 0) item.TrangThai = "Chưa duyệt";
                else item.TrangThai = "Đã duyệt";
            }
            return data;
        }
        public void Duyet(long id)
        {
            var dbEntry = db.ReceiptNotes.SingleOrDefault(x => x.ID == id);
            dbEntry.Status = 1;
            db.SaveChanges();
        }
        public void Delete(long id)
        {
            var listdetail = db.ReceiptNoteDetails.Where(x => x.ReceiptNoteID == id).ToList();
            foreach (var item in listdetail)
            {
                db.ReceiptNoteDetails.Remove(item);
            }
            var dbEntry = db.ReceiptNotes.SingleOrDefault(x => x.ID == id);
            db.ReceiptNotes.Remove(dbEntry);
            db.SaveChanges();
        }
=======

        #region Diagru
>>>>>>> 99a5e25fae08db9c5d494148fcb308322216744e
        #endregion
    }
}
