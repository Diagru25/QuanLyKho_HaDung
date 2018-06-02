using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class SupplierDAO
    {
        QLKDbContext db = null;
        public SupplierDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Supplier> ListAll()
        {
            return db.Suppliers.ToList();
        }

        public Supplier Get_Supplier_By_ID(long Supplier_ID)
        {
            return db.Suppliers.Find(Supplier_ID);
        }

        public bool Delete_Supplier(long Supplier_ID)
        {
            try
            {
                Supplier temp = db.Suppliers.Find(Supplier_ID);
                db.Suppliers.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_Supplier(Supplier item)
        {
            try
            {
                db.Suppliers.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_Supplier(Supplier item)
        {
            try
            {
                Supplier temp = db.Suppliers.Find(item.ID);
                temp.Name = item.Name;
                temp.Phone = item.Phone;
                temp.Address = item.Address;
                temp.Describe = item.Describe;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
