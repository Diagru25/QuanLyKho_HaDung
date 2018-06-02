using MainForm.Model.EF;
using MainForm.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model.DAO
{
    public class StorageDAO
    {
        QLKDbContext db = null;
        public StorageDAO()
        {
            db = new QLKDbContext();
        }

        #region Diagru
        public List<Storage_cbo> Load_Storage_cbo()
        {
            Storage_cbo temp = new Storage_cbo(); temp.ID = 0; temp.Name = "Tất cả kho";

            List<Storage_cbo> list = (from s in db.Storages
                                      select new Storage_cbo()
                                      {
                                          ID = s.ID,
                                          Name = s.Name
                                      }).ToList();

            list.Insert(0, temp);
            return list;

        }
        public List<NguyenLieuTonKho> Load_NL_TonKho(long Storage_ID)
        {
            List<NguyenLieuTonKho> list = new List<NguyenLieuTonKho>();

            if (Storage_ID != 0)
            {
                list = (from s in db.Storages
                        join sm in db.Storage_Material
                        on s.ID equals sm.StorageID
                        where (s.ID == Storage_ID)
                        join m in db.Materials
                        on sm.MaterialID equals m.ID
                        select new NguyenLieuTonKho()
                        {
                            ID = m.ID,
                            Name = m.Name,
                            Quantity = sm.Quantity,
                            Unit = m.Unit
                        }).ToList();
            }
            else
            {
               var list_temp = (from s in db.Storages
                                join sm in db.Storage_Material
                                on s.ID equals sm.StorageID
                                join m in db.Materials
                                on sm.MaterialID equals m.ID
                                select new NguyenLieuTonKho()
                                {
                                    ID = m.ID,
                                    Name = m.Name,
                                    Quantity = sm.Quantity,
                                    Unit = m.Unit
                                }).ToList();

                foreach(var item in list_temp)
                {
                    bool check = false;
                    if (list.Count > 0)
                    {
                        foreach (var item_list in list)
                        {
                            if(item.ID == item_list.ID)
                            {
                                item_list.Quantity += item.Quantity;
                                check = true;
                            }
                        }
                        if(check == false)
                            list.Add(item);
                    }
                    else
                    {
                        list.Add(item);
                    }
                    
                }
            }

            return list;
        }
        #endregion
    }
}
