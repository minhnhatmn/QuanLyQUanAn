using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_MonAN
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public List<MONAN> getMONAN()
        {
            return QLQA.MONANs.Select(k => k).ToList<MONAN>();
        }
        //Kiem tra trung ma mon
        public bool KiemtratrungMaMon(string pMa)
        {
            if (QLQA.MONANs.Count(c => c.MAMON == pMa) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }

        public int themMONAN(string mamon, string tenmon, int gia)
        {
            try
            {
                MONAN ma = new MONAN();
                ma.MAMON = mamon;
                ma.TENMON = tenmon;
                ma.GIA = gia;
                QLQA.MONANs.InsertOnSubmit(ma);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public void xoaMONAN(string mamon)
        {
            QLQA.MONAN_XOA(mamon);
            QLQA.SubmitChanges();
        }
        //Kiem tra trung ten mon
        public bool KiemtratrungTenMon(string pTen)
        {
            if (QLQA.MONANs.Count(c => c.TENMON == pTen) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }

        public int suaMONAN(string mamon, string tenmon, int gia)
        {
            try
            {
                MONAN ma = QLQA.MONANs.Where(t => t.MAMON == mamon).FirstOrDefault();
                ma.TENMON = tenmon;
                ma.GIA = gia;
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
