using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;

namespace MainForm.Model.DAO
{
    public class StorageDAO
    {
        QLKDbContext db = null;
        public StorageDAO()
        {
            db = new QLKDbContext();
        }
        public List<Storage> ListAll()
        {
            return db.Storages.ToList();
        }
    }
}
