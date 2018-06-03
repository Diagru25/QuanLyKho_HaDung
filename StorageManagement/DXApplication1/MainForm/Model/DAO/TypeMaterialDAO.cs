using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class TypeMaterialDAO
    {
        QLKDbContext db = null;

        public TypeMaterialDAO()
        {
            db = new QLKDbContext();
        }


        #region Diagru
        public List<TypeMaterial> ListAll()
        {
            return db.TypeMaterials.ToList();
        }

        public TypeMaterial Get_TypeMal_By_ID(long TypeMal_ID)
        {
            return db.TypeMaterials.Find(TypeMal_ID);
        }

        public bool Delete_TypeMaterial(long TypeMal_ID)
        {
            try
            {
                TypeMaterial temp = db.TypeMaterials.Find(TypeMal_ID);
                db.TypeMaterials.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_TypeMaterial(TypeMaterial item)
        {
            try
            {
                db.TypeMaterials.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_TypeMaterial(TypeMaterial item)
        {
            try
            {
                TypeMaterial temp = db.TypeMaterials.Find(item.ID);
                temp.Name = item.Name;
                temp.SupplierID = item.SupplierID;

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
