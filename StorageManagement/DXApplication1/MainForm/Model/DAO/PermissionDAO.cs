using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class PermissionDAO
    {
        QLKDbContext db = null;

        public PermissionDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Permission> ListAll()
        {
            return db.Permissions.ToList();
        }
        public Permission Get_Per_By_ID(long Per_ID)
        {
            return db.Permissions.Find(Per_ID);
        }

        public bool Delete_Permission(long Per_ID)
        {
            try
            {
                Permission temp = db.Permissions.Find(Per_ID);
                db.Permissions.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public long Insert_Permission(Permission item)
        {
            try
            {
                db.Permissions.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_Permission(Permission item)
        {
            try
            {
                Permission temp = db.Permissions.Find(item.ID);
                temp.Name = item.Name;

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
