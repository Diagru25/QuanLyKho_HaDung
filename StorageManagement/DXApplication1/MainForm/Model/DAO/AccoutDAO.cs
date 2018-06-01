using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;

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
                var dbEntry = db.Accounts.SingleOrDefault(x => x.UserName == username && x.PassWord == password);
                return dbEntry;
            }
            catch
            {
                return null;
            }
        }
    }
}
