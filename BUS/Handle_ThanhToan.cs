using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Handle_ThanhToan
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public List<KHACHHANG> timkiemKHACHHANG(string sdt)
        {
            return QLQA.KHACHHANGs.Where(k => k.SDT == sdt).ToList<KHACHHANG>();
        }
        public List<KHACHHANG> GetKHACHHANG()
        {
            return QLQA.KHACHHANGs.Select(k => k).ToList<KHACHHANG>();
        }
        public List<GOIMON> GetGoiMon()
        {
            return QLQA.GOIMONs.Where(k => k.TINHTRANG == 0).ToList<GOIMON>();
        }
        public List<CHITIETGOIMON> GetCTGM(string magoimon)
        {
            return QLQA.CHITIETGOIMONs.Where(k => k.MAGOIMON == magoimon).ToList<CHITIETGOIMON>();
        }
        public List<DATBAN> GetDATBAN()
        {
            return QLQA.DATBANs.Where(k => k.TINHTRANG == 0).ToList<DATBAN>();
        }
        public List<CHITIETDATBAN> GetCTDB(string maDATBAN)
        {
            return QLQA.CHITIETDATBANs.Where(k => k.MADATBAN == maDATBAN).ToList<CHITIETDATBAN>();
        }
        public List<HOADON> GetHOADON()
        {
            return QLQA.HOADONs.Select(t => t).ToList<HOADON>();
        }
        public string getMABAN_DATBAN(string madatban)
        {
            try
            {
                DATBAN datban = QLQA.DATBANs.Where(t => t.MADATBAN == madatban).FirstOrDefault();
                return datban.MABAN;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public string getMABAN_GOIMON(string maGOIMON)
        {
            try
            {
                GOIMON goimon = QLQA.GOIMONs.Where(t => t.MAGOIMON == maGOIMON).FirstOrDefault();
                return goimon.MABAN;
            }
            catch (Exception)
            {

                return "";
            }
        }
        public int tongtienGOIMON(string magoimon)
        {
            int kq = 0;
            List<CHITIETGOIMON> list = GetCTGM(magoimon);
            foreach (var item in list)
            {
                MONAN monan = QLQA.MONANs.Where(t => t.MAMON == item.MAMON).FirstOrDefault();
                kq = kq + int.Parse(monan.GIA.ToString()) * int.Parse(item.SOLUONG.ToString());
            }
            return kq;
        }
        public int tongtienDATBAN(string madatban)
        {
            int kq = 0;
            List<CHITIETDATBAN> list = GetCTDB(madatban);
            foreach (var item in list)
            {
                MONAN monan = QLQA.MONANs.Where(t => t.MAMON == item.MAMON).FirstOrDefault();
                kq = kq + int.Parse(monan.GIA.ToString()) * int.Parse(item.SOLUONG.ToString());
            }
            return kq;
        }
        public int themHOADON(string mahd, string manv, string makh, string phuongthucthanhtoan, string magoimon, string madatban, int tongtien)
        {
            try
            {
                if (kthoadon(magoimon, madatban))
                {
                    if (magoimon.Equals("") == false)
                    {
                        GOIMON goimon = QLQA.GOIMONs.Where(t => t.MAGOIMON == magoimon).FirstOrDefault();
                        HOADON hd = new HOADON();
                        BAN ban = QLQA.BANs.Where(t => t.MABAN == goimon.MABAN).FirstOrDefault();
                        KHACHHANG kh = QLQA.KHACHHANGs.Where(t => t.MAKH == makh).FirstOrDefault();
                        kh.DIEM = kh.DIEM + tongtien / 1000;
                        ban.TINHTRANG = "Trống";
                        goimon.TINHTRANG = 1;
                        hd.MAHOADON = mahd;
                        hd.MANV = manv;
                        hd.MAKH = makh;
                        hd.MAGOIMON = magoimon;
                        hd.TONGTIEN = tongtien;
                        hd.PHUONGTHUCTHANHTOAN = phuongthucthanhtoan;
                        hd.THOIGIAN = DateTime.Now;
                        QLQA.HOADONs.InsertOnSubmit(hd);
                        QLQA.SubmitChanges();
                        return 1;
                    }
                    else if (madatban.Equals("") == false)
                    {
                        DATBAN datban = QLQA.DATBANs.Where(t => t.MADATBAN == madatban).FirstOrDefault();
                        HOADON hd = new HOADON();
                        BAN ban = QLQA.BANs.Where(t => t.MABAN == datban.MABAN).FirstOrDefault();
                        KHACHHANG kh = QLQA.KHACHHANGs.Where(t => t.MAKH == makh).FirstOrDefault();
                        kh.DIEM = kh.DIEM + tongtien / 1000;
                        datban.TINHTRANG = 1;
                        ban.TINHTRANG = "Trống";
                        hd.MAHOADON = mahd;
                        hd.MANV = manv;
                        hd.MAKH = makh;
                        hd.MADATBAN = madatban;
                        hd.TONGTIEN = tongtien;
                        hd.PHUONGTHUCTHANHTOAN = phuongthucthanhtoan;
                        hd.THOIGIAN = DateTime.Now;
                        QLQA.HOADONs.InsertOnSubmit(hd);
                        QLQA.SubmitChanges();
                        return 1;
                    }
                    return -1;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        public bool kthoadon(string magoimon, string madatban)
        {
            bool kt = false;
            try
            {
                if (magoimon.Equals("") == false)
                {
                    HOADON hoadon = QLQA.HOADONs.Where(t => t.MAGOIMON == magoimon).FirstOrDefault();
                    if (hoadon == null)
                    {
                        kt = true;
                    }
                }
                else if (madatban.Equals("") == false)
                {
                    HOADON hoadon = QLQA.HOADONs.Where(t => t.MADATBAN == madatban).FirstOrDefault();
                    if (hoadon == null)
                    {
                        kt = true;
                    }
                }
            }
            catch (Exception)
            {
                kt = false;
            }
            return kt;
        }
    }
}
