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
    public class DeliveryNoteDAO
    {
        QLKDbContext db = null;
        public DeliveryNoteDAO()
        {
            db = new QLKDbContext();
        }
<<<<<<< HEAD
        #region HG
        public long Insert(DeliveryNote item)
        {
            try
            {
                db.DeliveryNotes.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }
        public bool InsertDetail(DeliveryNoteDetail item)
        {
            try
            {
                db.DeliveryNoteDetails.Add(item);
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
                var dbEntry = db.DeliveryNoteDetails.SingleOrDefault(x => x.ID == id);
                db.DeliveryNoteDetails.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<DeliveryNoteDetailView> GetDetail(long? id)
        {
            var data = (from a in db.DeliveryNoteDetails
                        join b in db.Materials on a.MaterialID equals b.ID
                        where a.DeliveryNoteID == id
                        select new DeliveryNoteDetailView()
                        {
                            ID = a.ID,
                            DeliveryNoteID = id,
                            MaterialID = a.MaterialID,
                            MaterialName = b.Name,
                            Price = a.Price,
                            Quantity = a.Quantity
                        }).ToList();
            return data;
        }
        public void Amount(long? id)
        {
            var data = db.DeliveryNoteDetails.Where(x => x.DeliveryNoteID == id).ToList();
            Decimal? res = 0;
            foreach(var item in data)
            {
                res += item.Quantity * item.Price;
            }
            var dbEntry = db.DeliveryNotes.SingleOrDefault(x => x.ID == id);
            dbEntry.Amount = res;
            db.SaveChanges();
        }
        public List<DeliveryNoteView> GetNote()
        {
            var data = (from a in db.DeliveryNotes
                        join b in db.Storages on a.StorageID equals b.ID
                        join c in db.Customers on a.CustomerID equals c.ID
                        join d in db.Employees on a.EmployeeID equals d.ID
                        select new DeliveryNoteView()
                        {
                            ID = a.ID,
                            StorageID = a.StorageID,
                            StorageName = b.Name,
                            CustomerID = a.CustomerID,
                            CustomerName = c.Name,
                            EmployeeID = a.EmployeeID,
                            EmployeeName = d.Name,
                            DeliveryDate = a.DeliveryDate,
                            Status = a.Status,
                            Amount = a.Amount
                        }).ToList();
            foreach(var item in data)
            {
                if (item.Status == 0) item.TrangThai = "Chưa duyệt";
                else item.TrangThai = "Đã duyệt";
            }
            return data;
        }     
        public void Duyet(long id)
        {
            var dbEntry = db.DeliveryNotes.SingleOrDefault(x => x.ID == id);
            dbEntry.Status = 1;
            db.SaveChanges();
        }
        public void Delete(long id)
        {
            var listdetail = db.DeliveryNoteDetails.Where(x => x.DeliveryNoteID == id).ToList();
            foreach(var item in listdetail)
            {
                db.DeliveryNoteDetails.Remove(item);
            }
            var dbEntry = db.DeliveryNotes.SingleOrDefault(x => x.ID == id);
            db.DeliveryNotes.Remove(dbEntry);
            db.SaveChanges();
        }
=======

        #region Diagru
>>>>>>> 99a5e25fae08db9c5d494148fcb308322216744e
        #endregion
    }
}
