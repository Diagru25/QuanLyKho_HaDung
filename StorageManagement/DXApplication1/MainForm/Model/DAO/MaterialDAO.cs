using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;

namespace MainForm.Model.DAO
{
<<<<<<< HEAD

=======
>>>>>>> 99a5e25fae08db9c5d494148fcb308322216744e
    public class MaterialDAO
    {
        QLKDbContext db = null;
        public MaterialDAO()
        {
            db = new QLKDbContext();
        }
<<<<<<< HEAD
        #region HG
=======

        #region Diagru
>>>>>>> 99a5e25fae08db9c5d494148fcb308322216744e
        public List<Material> ListAll()
        {
            return db.Materials.ToList();
        }
<<<<<<< HEAD
=======

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
>>>>>>> 99a5e25fae08db9c5d494148fcb308322216744e
        #endregion
    }
}
