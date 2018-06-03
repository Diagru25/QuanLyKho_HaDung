using MainForm.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class EmployeeDAO
    {
        QLKDbContext db = null;
        public EmployeeDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Employee> ListAll()
        {
            return db.Employees.ToList();
        }

        public Employee Get_Emp_By_ID(long? Emp_ID)
        {
            return db.Employees.Find(Emp_ID);
        }

        public bool Delete_Employee(long Emp_ID)
        {
            try
            {
                Employee temp = db.Employees.Find(Emp_ID);
                db.Employees.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public long Insert_Employee(Employee item)
        {
            try
            {
                db.Employees.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Update_Employee(Employee item)
        {
            try
            {
                Employee temp = db.Employees.Find(item.ID);
                temp.Name = item.Name;
                temp.Phone = item.Phone;
                temp.Regency = item.Regency;
                temp.Gender = item.Gender;
                temp.DateOfBirth = item.DateOfBirth;
                temp.Address = item.Address;
                temp.Email = item.Email;

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
