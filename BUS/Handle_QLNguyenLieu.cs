using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_QLNguyenLieu
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public Handle_QLNguyenLieu() { }

        public List<NGUYENLIEU> getNGUYENLIEU()
        {
            return QLQA.NGUYENLIEUs.Select(k => k).ToList<NGUYENLIEU>();
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
        //Kiem tra trung TenNL
        public bool KiemtratrungTenNL(string pTen)
        {
            if (QLQA.NGUYENLIEUs.Count(c => c.TENNL == pTen) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Tim nguyen lieu
        public List<NGUYENLIEU> timNGUYENLIEU(string manl)
        {
            List<NGUYENLIEU> list = QLQA.NGUYENLIEUs.Where(t => t.MANL == manl).ToList();
            return list;
        }
        public void xoaNGUYENLIEU(string manl)
        {
            QLQA.NGUYENLIEU_XOA(manl);
            QLQA.SubmitChanges();
        }
        public void themNGUYENLIEU(string manl, string tennl, string dvt)
        {
            NGUYENLIEU nl = new NGUYENLIEU();
            nl.MANL = manl;
            nl.TENNL = tennl;
            nl.SOLUONG = 0;
            nl.DVT = dvt;
            QLQA.NGUYENLIEUs.InsertOnSubmit(nl);
            QLQA.SubmitChanges();
        }
    }
}
