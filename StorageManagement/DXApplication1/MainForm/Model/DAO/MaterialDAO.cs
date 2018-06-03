using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Model.EF;

namespace MainForm.Model.DAO
{

    public class MaterialDAO
    {
        QLKDbContext db = null;
        public MaterialDAO()
        {
            db = new QLKDbContext();
        }
        #region HG
        public List<Material> ListAll()
        {
            return db.Materials.ToList();
        }
        #endregion
    }
}
