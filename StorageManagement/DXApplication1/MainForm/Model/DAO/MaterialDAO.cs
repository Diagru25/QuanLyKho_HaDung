using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class MaterialDAO
    {
        QLKDbContext db = null;
        public MaterialDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Material> ListAll()
        {
            return db.Materials.ToList();
        }

        public Material Get_Material_By_ID(long Material_ID)
        {
            return db.Materials.Find(Material_ID);
        }

        public bool Delete_Material(long Material_ID)
        {
            try
            {
                Material temp = db.Materials.Find(Material_ID);
                db.Materials.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_Material(Material item)
        {
            try
            {
                db.Materials.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_Material(Material item)
        {
            try
            {
                Material temp = db.Materials.Find(item.ID);
                temp.Name = item.Name;
                temp.Price = item.Price;
                temp.Unit = item.Unit;
                temp.TypeMaterialID = item.TypeMaterialID;

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
