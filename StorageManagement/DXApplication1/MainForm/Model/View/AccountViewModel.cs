using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.ViewModel
{
    public class AccountViewModel
    {
        public string UserName { get; set; }

        public string PassWord { get; set; }

        public long? EmployeeID { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public long? PermissionID { get; set; }

        public string Status_Text { get; set; }

        public string Permission_Text { get; set; }
    }
}
