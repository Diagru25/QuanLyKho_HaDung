using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class ProductDAO
    {
        QLKDbContext db = null;
        public ProductDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Product> ListAll()
        {
            return db.Products.ToList();
        }

        public Product Get_Pro_By_ID(long Pro_ID)
        {
            return db.Products.Find(Pro_ID);
        }

        public bool Delete_Product(long Pro_ID)
        {
            try
            {
                Product temp = db.Products.Find(Pro_ID);
                db.Products.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_Product(Product item)
        {
            try
            {
                db.Products.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_Product(Product item)
        {
            try
            {
                Product temp = db.Products.Find(item.ID);
                temp.Name = item.Name;
                temp.Unit = item.Unit;
                temp.TypeProductID = item.TypeProductID;
                temp.UserID = item.UserID;

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
