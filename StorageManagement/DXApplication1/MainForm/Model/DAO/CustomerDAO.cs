using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;

namespace MainForm.Model.DAO
{
    public class CustomerDAO
    {
        QLKDbContext db = null;
        public CustomerDAO()
        {
            db = new QLKDbContext();
        }
        public List<Customer> ListAll()
        {
            return db.Customers.ToList();
        }
    }
}
