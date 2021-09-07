using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_Ban
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public Handle_Ban() { }

        public List<BAN> GetBan()
        {
            return QLQA.BANs.Select(k => k).ToList<BAN>();
        }

        //Kiem tra trung MaBan
        public bool KiemtratrungMaBan(string pMa)
        {
            if (QLQA.BANs.Count(c => c.MABAN == pMa) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Kiem tra trung ten Ban
        public bool KiemtratrungLoaiBan(string pLoai)
        {
            if (QLQA.BANs.Count(c => c.LOAIBAN == pLoai) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Them
        public void ThemBan(string pMa, string pLoaiBan, string pTinhTrang)
        {
            BAN ban = new BAN();
            ban.MABAN = pMa;
            ban.LOAIBAN = pLoaiBan;
            ban.TINHTRANG = pTinhTrang;

            QLQA.BANs.InsertOnSubmit(ban);
            QLQA.SubmitChanges();
        }

        //Xoa
        public void XoaBan(string maban)
        {
            QLQA.BAN_XOA(maban);
            QLQA.SubmitChanges();
        }

        //Sua
        public void SuaBan(string pMa, string pLoaiBan)
        {
            BAN ban = QLQA.BANs.Where(m => m.MABAN == pMa).FirstOrDefault();
            if (ban != null)
            {
                ban.MABAN = pMa;
                ban.LOAIBAN = pLoaiBan;

                QLQA.SubmitChanges();
            }
        }


    }
}
