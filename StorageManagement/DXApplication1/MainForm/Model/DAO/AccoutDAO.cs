using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;
using MainForm.Model.ViewModel;

namespace MainForm.Model.DAO
{
   
    public class AccoutDAO
    {
        QLKDbContext db = null;
        public AccoutDAO()
        {
            db = new QLKDbContext();
        }
        public Account Login(string username, string password)
        {
            try
            {
                var dbEntry = db.Accounts.SingleOrDefault(x => x.UserName == username && x.PassWord == password && x.Status == true);
                return dbEntry;
            }
            catch
            {
                return null;
            }
        }

        #region Diagru
        public bool Change_Pass(string user_name, string new_pass)
        {
            try
            {
                Account item = db.Accounts.Where(x => x.UserName == user_name).SingleOrDefault();

                item.PassWord = new_pass;

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public string Get_Name_Permision_By_PerID(long? per_id)
        {
            return db.Permissions.Find(per_id).Name;
        }

        public List<AccountViewModel> List_View_Account()
        {
            List<AccountViewModel> list = (from a in db.Accounts
                                     join p in db.Permissions
                                     on a.PermissionID equals p.ID
                                     join n in db.Employees
                                     on a.EmployeeID equals n.ID
                                     select new AccountViewModel()
                                     {
                                         UserName = a.UserName,
                                         PassWord = a.PassWord,
                                         PermissionID = p.ID,
                                         Permission_Text = p.Name,
                                         Status = a.Status,
                                         Status_Text = a.Status == true ? "Kích hoạt" : "Khóa",
                                         EmployeeID = a.EmployeeID,
                                         CreateDate = a.CreateDate,
                                     }).ToList();
            return list;
        }

        public bool Delete_Account(string user_name)
        {
            try
            {
                Account temp = db.Accounts.Find(user_name);
                db.Accounts.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Insert_Account(Account item)
        {
            try
            {
                db.Accounts.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_Account(Account item)
        {
            try
            {
                Account temp = db.Accounts.Find(item.UserName);
                temp.PermissionID = item.PermissionID;
                temp.UpdateDate = DateTime.Now;
                temp.EmployeeID = item.EmployeeID;
                temp.Status = item.Status;

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
