using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class CustomerDAO
    {
        QLKDbContext db = null;
        public CustomerDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Customer> ListAll()
        {
            return db.Customers.ToList();
        }

        public Customer Get_Cus_By_ID(long Cus_ID)
        {
            return db.Customers.Find(Cus_ID);
        }

        public bool Delete_Customer(long Cus_ID)
        {
            try
            {
                Customer temp = db.Customers.Find(Cus_ID);
                db.Customers.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_Customer(Customer item)
        {
            try
            {
                db.Customers.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_Customer(Customer item)
        {
            try
            {
                Customer temp = db.Customers.Find(item.ID);
                temp.Name = item.Name;
                temp.Phone = item.Phone;
                temp.DateOfBirth = item.DateOfBirth;
                temp.Address = item.Address;

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
