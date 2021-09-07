using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_DatBan
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public List<DATBAN> GetDatBan()
        {
            return QLQA.DATBANs.Where(k => k.TINHTRANG!=1).ToList<DATBAN>();
        }
        public List<BAN> GetBan()
        {
            return QLQA.BANs.Select(k => k).ToList<BAN>();
        }
        public List<KHACHHANG> GetKhachHang()
        {
            return QLQA.KHACHHANGs.Select(k => k).ToList<KHACHHANG>();
        }
        public List<MONAN> GetMonAn()
        {
            return QLQA.MONANs.Select(k => k).ToList<MONAN>();
        }
        public List<CHITIETDATBAN> GetCTDatBan()
        {
            return QLQA.CHITIETDATBANs.Select(k => k).ToList<CHITIETDATBAN>();
        }

        //Kiem tra trung MaBan
        public bool KiemtratrungMaDatBan(string pMa)
        {
            if (QLQA.DATBANs.Count(c => c.MADATBAN == pMa) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //dat ban
        #region DatBan
        //Them
        public int ThemDatBan(string pMaDat, string pMaNV, string pMaKH, DateTime pThoiGianDat, string pMaBan, string buoi)
        {
            try
            {
                DATBAN db = new DATBAN();
                db.MADATBAN = pMaDat;
                db.MANV = pMaNV;
                db.MAKH = pMaKH;
                db.THOIGIANLAPDAT = DateTime.Now;
                db.THOIGIANDAT = pThoiGianDat;
                db.MABAN = pMaBan;
                db.BUOI = buoi;
                db.TINHTRANG = 0;
                QLQA.DATBANs.InsertOnSubmit(db);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        //Xoa
        public int XoaDatBan(string pMa)
        {
            try
            {
                DATBAN db = QLQA.DATBANs.Where(m => m.MADATBAN == pMa).FirstOrDefault();
                if (db != null)
                {
                    QLQA.DATBANs.DeleteOnSubmit(db);
                    QLQA.SubmitChanges();
                    return 1;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        //Sua
        public int SuaDatBan(string pMaDat, string pMaNV, string pMaKH, DateTime pThoiGianDat, string pMaBan, string buoi)
        {
            try
            {
                DATBAN db = QLQA.DATBANs.Where(m => m.MADATBAN == pMaDat).FirstOrDefault();
                if (db != null)
                {
                    
                    db.MANV = pMaNV;
                    db.MAKH = pMaKH;
                    db.THOIGIANLAPDAT = DateTime.Now;
                    db.THOIGIANDAT = pThoiGianDat;
                    db.MABAN = pMaBan;
                    db.BUOI = buoi;
                    QLQA.SubmitChanges();
                    return 1;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
        public List<DATBAN> TimDatBan(DateTime thoigiandat, string buoi)
        {
            string date = thoigiandat.ToShortTimeString();
            DateTime enteredDate = DateTime.Parse(date);
            List<DATBAN> list = QLQA.DATBANs.Where(m => m.THOIGIANLAPDAT == enteredDate && m.BUOI==buoi).ToList<DATBAN>();
            return list;
        }
        #endregion


        // chi tiet dat ban
        #region ChiTietDatBan


        //Them
        public int ThemCTDatBan(string pMaDat, string pMaMon, int pSoLuong)
        {
            try
            {
                CHITIETDATBAN ctdb = new CHITIETDATBAN();
                ctdb.MADATBAN = pMaDat;
                ctdb.MAMON = pMaMon;
                ctdb.SOLUONG = pSoLuong;
                QLQA.CHITIETDATBANs.InsertOnSubmit(ctdb);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        //Xoa
        public int XoaCTDatBan(int stt)
        {
            try
            {
                CHITIETDATBAN ctdb = QLQA.CHITIETDATBANs.Where(m => m.STT == stt).FirstOrDefault();
                if (ctdb != null)
                {
                    QLQA.CHITIETDATBANs.DeleteOnSubmit(ctdb);
                    QLQA.SubmitChanges();
                    return 1;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        //Sua
        public int SuaCTDatBan(int stt, string pMaMon, int pSoLuong)
        {
            try
            {
                CHITIETDATBAN ctdb = QLQA.CHITIETDATBANs.Where(m => m.STT == stt).FirstOrDefault();
                if (ctdb != null)
                {
                    ctdb.MAMON = pMaMon;
                    ctdb.SOLUONG = pSoLuong;

                    QLQA.SubmitChanges();
                    return 1;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
        public List<CHITIETDATBAN> GetCHITIETDATBAN(string madatban)
        {
            return QLQA.CHITIETDATBANs.Where(k => k.MADATBAN==madatban).ToList<CHITIETDATBAN>();
        }
        #endregion



    }
}
