using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_GoiMon
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public Handle_GoiMon() { }
        public List<MONAN> GetMonAn()
        {
            return QLQA.MONANs.Select(k => k).ToList<MONAN>();
        }
        public List<BAN> GetBan()
        {
            return QLQA.BANs.Select(k => k).ToList<BAN>();
        }
        public List<GOIMON> GetGoiMon()
        {
            return QLQA.GOIMONs.Select(k => k).ToList<GOIMON>();
        }
        public List<CHITIETGOIMON> GetCTGM(string magoimon)
        {
            return QLQA.CHITIETGOIMONs.Where(k => k.MAGOIMON==magoimon).ToList<CHITIETGOIMON>();
        }
        public int themGOIMON(string magoi, string manv, string maban)
        {
            try
            {
                BAN ban = QLQA.BANs.Where(t => t.MABAN == maban).FirstOrDefault();

                if (ban.TINHTRANG == "Đang sử dụng")
                {
                    return -1;
                }
                else
                {
                    GOIMON goimon = new GOIMON();
                    goimon.MAGOIMON = magoi;
                    goimon.MANV = manv;
                    goimon.MABAN = maban;
                    goimon.THOIGIANGOI = DateTime.Now;
                    goimon.TINHTRANG = 0;
                    ban.TINHTRANG = "Đang sử dụng";
                    QLQA.GOIMONs.InsertOnSubmit(goimon);
                    QLQA.SubmitChanges();
                    return 1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int suaGOIMON(string magoi, string manv, string maban)
        {
            try
            {
                GOIMON goimon = QLQA.GOIMONs.Where(l => l.MAGOIMON == magoi).FirstOrDefault();
                goimon.MAGOIMON = magoi;
                goimon.MANV = manv;
                goimon.MABAN = maban;
                goimon.THOIGIANGOI = DateTime.Now;
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int xoaGOIMON(string magoi)
        {
            try
            {
                List<CHITIETGOIMON> list = QLQA.CHITIETGOIMONs.Where(k => k.MAGOIMON == magoi).ToList<CHITIETGOIMON>();
                if (list==null)
                {
                    return -1;
                }
                else
                {
                    GOIMON goimon = QLQA.GOIMONs.Where(l => l.MAGOIMON == magoi).FirstOrDefault();
                    QLQA.GOIMONs.DeleteOnSubmit(goimon);
                    QLQA.SubmitChanges();
                    return 1;
                }
                
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int themCTGOIMON(string magoi, string mamamon, int soluong)
        {
            try
            {
                CHITIETGOIMON ct = new CHITIETGOIMON();
                ct.MAGOIMON = magoi;
                ct.MAMON = mamamon;
                ct.SOLUONG = soluong;
                QLQA.CHITIETGOIMONs.InsertOnSubmit(ct);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int suaCTGOIMON(int stt, string mamamon, int soluong)
        {
            try
            {
                CHITIETGOIMON ct = QLQA.CHITIETGOIMONs.Where(t => t.STT == stt).FirstOrDefault();
                ct.MAMON = mamamon;
                ct.SOLUONG = soluong;
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int xoaCTGOIMON(int stt)
        {
            try
            {
                CHITIETGOIMON ct = QLQA.CHITIETGOIMONs.Where(t => t.STT == stt).FirstOrDefault();
                QLQA.CHITIETGOIMONs.DeleteOnSubmit(ct);
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
