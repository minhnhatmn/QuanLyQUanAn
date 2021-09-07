using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_QLKho
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public Handle_QLKho() { }

        public List<NGUYENLIEU> getNGUYENLIEU()
        {
            return QLQA.NGUYENLIEUs.Select(t=>t).ToList();
        }
        //Tim nguyen lieu
        public List<NGUYENLIEU> timNGUYENLIEU(string manl)
        {
            List<NGUYENLIEU> list = QLQA.NGUYENLIEUs.Where(t => t.MANL == manl).ToList<NGUYENLIEU>();
            return list;
        }
        //Kiem tra trung MaNL
        public bool KiemtratrungMaNL(string pMa)
        {
            if (QLQA.NGUYENLIEUs.Count(c => c.MANL == pMa) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }

        public List<NHAPKHO> getNhapKho()
        {
            return QLQA.NHAPKHOs.Select(k => k).ToList<NHAPKHO>();
        }
        public int NHAPKHO(string manl, int soluong, string nhacc, int ngayhethan, string manv)
        {
            try
            {
                string ngaynhap = DateTime.Now.ToShortTimeString();
                DateTime enteredDate = DateTime.Parse(ngaynhap);
                QLQA.KHO_NHAP(manl, soluong, nhacc, enteredDate, ngayhethan, manv);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public List<XUATKHO> getXuatKho()
        {
            return QLQA.XUATKHOs.Select(k => k).ToList<XUATKHO>();
        }
        public int XUATKHO(string manl, int soluong, string manv)
        {
            try
            {
                string ngayxuat = DateTime.Now.ToShortTimeString();
                DateTime enteredDate = DateTime.Parse(ngayxuat);
                QLQA.KHO_XUAT(manl, soluong, enteredDate, manv);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }

    }
}
    
