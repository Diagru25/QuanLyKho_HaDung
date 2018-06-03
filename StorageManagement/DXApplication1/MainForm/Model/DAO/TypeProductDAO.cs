using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class TypeProductDAO
    {
        QLKDbContext db = null;
        public TypeProductDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<TypeProduct> ListAll()
        {
            return db.TypeProducts.ToList();
        }

        public TypeProduct Get_TypePro_By_ID(long TypePro_ID)
        {
            return db.TypeProducts.Find(TypePro_ID);
        }

        public bool Delete_TypeProduct(long TypePro_ID)
        {
            try
            {
                TypeProduct temp = db.TypeProducts.Find(TypePro_ID);
                db.TypeProducts.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_TypeProduct(TypeProduct item)
        {
            try
            {
                db.TypeProducts.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_TypeProduct(TypeProduct item)
        {
            try
            {
                TypeProduct temp = db.TypeProducts.Find(item.ID);
                temp.Name = item.Name;
                temp.Faculty = item.Faculty;
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
