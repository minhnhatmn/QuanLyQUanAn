using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class XuLy
    {
        DataClasses1DataContext qlqa = new DataClasses1DataContext();
        #region DangNhap
        public int DangNhap(string manv, string mk)
        {
            int role = -1;
            NHANVIEN nv = qlqa.NHANVIENs.Where(t => t.MANV == manv && t.MATKHAU == mk).FirstOrDefault();
            if (nv != null)
            {
                if (nv.CHUCVU.ToString().Equals("Thu ngân"))
                {
                    role = 1;
                }
                else if (nv.CHUCVU.ToString().Equals("Phục vụ"))
                {
                    role = 2;
                }
                else if (nv.CHUCVU.ToString().Equals("Kiểm kho"))
                {
                    role = 3;
                }
                else if (nv.CHUCVU.ToString().Equals("Quản lý"))
                {
                    role = 4;
                }
            }
            return role;
        }
        //Kiem tra ten dang nhap
        public bool KiemTraTenDangNhap(string tendn)
        {
            if (qlqa.NHANVIENs.Count(c => c.MANV == tendn) > 0)
            {
                return true; //đúng
            }
            return false; //không đúng
        }
        //Kiem tra mat khau
        public bool KiemTraMatKhau(string matkhau)
        {
            if (qlqa.NHANVIENs.Count(c => c.MATKHAU == matkhau) > 0)
            {
                return true; //đúng
            }
            return false; //không đúng
        }
        #endregion
        #region MonAn
        public List<MONAN> getMONAN()
        {
            List<MONAN> list = new List<MONAN>();
            list = qlqa.MONANs.Select(t => t).ToList<MONAN>();
            return list;
        }
        public int themMONAN(string mamon, string tenmon, int gia)
        {
            try
            {
                MONAN ma = new MONAN();
                ma.MAMON = mamon;
                ma.TENMON = tenmon;
                ma.GIA = gia;
                qlqa.MONANs.InsertOnSubmit(ma);
                qlqa.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public void xoaMONAN(string mamon)
        {
            qlqa.MONAN_XOA(mamon);
            qlqa.SubmitChanges();
        }
        public int suaMONAN(string mamon, string tenmon, int gia)
        {
            try
            {
                MONAN ma = qlqa.MONANs.Where(t => t.MAMON == mamon).FirstOrDefault();
                ma.TENMON = tenmon;
                ma.GIA = gia;
                qlqa.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        #endregion
        #region KHO
        public List<NHAPKHO> getNhapKho()
        {
            List<NHAPKHO> list = new List<NHAPKHO>();
            list = qlqa.NHAPKHOs.Select(t => t).ToList<NHAPKHO>();
            return list;
        }
        public void NHAPKHO(string manl, int soluong, string nhacc, int ngayhethan, string manv)
        {
            string ngaynhap = DateTime.Now.ToShortTimeString();
            DateTime enteredDate = DateTime.Parse(ngaynhap);
            qlqa.KHO_NHAP(manl, soluong, nhacc, enteredDate, ngayhethan, manv);
            qlqa.SubmitChanges();
        }
        public List<XUATKHO> getXuatKho()
        {
            List<XUATKHO> list = new List<XUATKHO>();
            list = qlqa.XUATKHOs.Select(t => t).ToList<XUATKHO>();
            return list;
        }
        public void XUATKHO(string manl, int soluong, string manv)
        {
            string ngayxuat = DateTime.Now.ToShortTimeString();
            DateTime enteredDate = DateTime.Parse(ngayxuat);
            qlqa.KHO_XUAT(manl, soluong, enteredDate, manv);
            qlqa.SubmitChanges();
        }
        #endregion
        #region BAN
        public List<BAN> getBAN()
        {
            List<BAN> list = new List<BAN>();
            list = qlqa.BANs.Select(t => t).ToList<BAN>();
            return list;
        }
        public int themBAN(string maban, string loaiban)
        {
            try
            {
                BAN ban = new BAN();
                ban.MABAN = maban;
                ban.LOAIBAN = loaiban;
                ban.TINHTRANG = "Trống";
                qlqa.BANs.InsertOnSubmit(ban);
                qlqa.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public int suaBAN(string maban, string loaiban)
        {
            try
            {
                BAN ban = qlqa.BANs.Where(t => t.MABAN == maban).FirstOrDefault();
                ban.LOAIBAN = loaiban;
                qlqa.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        #endregion
        #region NHANVIEN
        public List<NHANVIEN> getNHANVIEN()
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = qlqa.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
            return list;
        }
        public List<NHANVIEN> timNHANVIEN(string manv)
        {
            List<NHANVIEN> list = qlqa.NHANVIENs.Where(t => t.MANV == manv).ToList();
            return list;
        }
        public int themNHANVIEN(string manv, string tennv, int cmnd, string sdt, DateTime ngaysinh, string gioitinh, string chucvu, string matkhau)
        {
            try
            {
                string date = ngaysinh.ToShortTimeString();
                DateTime enteredDate = DateTime.Parse(date);
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = manv;
                nv.TENHANVIEN = tennv;
                nv.CMND = cmnd;
                nv.SDT = sdt;
                nv.NGAYSINH = enteredDate;
                nv.GIOITINH = gioitinh;
                nv.CHUCVU = chucvu;
                nv.MATKHAU = matkhau;
                qlqa.NHANVIENs.InsertOnSubmit(nv);
                qlqa.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public int xoaNHANVIEN(string manv)
        {
            try
            {
                qlqa.NHANVIEN_XOA(manv);
                qlqa.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public bool KiemTraSDT(string sdt)
        {
            sdt = sdt.Trim();
            if (sdt.Count() != 10)
                return false;
            foreach (char so in sdt)
            {
                if (!char.IsDigit(so))
                    return false;
            }
            if (sdt.ElementAt(0) != '0')
                return false;
            return true;

        }

        //kiem tra CMND
        public bool KiemTraCMND(string cmnd)
        {
            cmnd = cmnd.Trim();
            if (cmnd.Length != 12 && cmnd.Length != 9)
                return false;
            foreach (char so in cmnd)
            {
                if (!char.IsDigit(so))
                    return false;
            }
            return true;

        }

        #endregion
        #region KHACHHANG
        public List<KHACHHANG> getKHACHHANG()
        {
            List<KHACHHANG> list = new List<KHACHHANG>();
            list = qlqa.KHACHHANGs.Select(t => t).ToList<KHACHHANG>();
            return list;
        }
        #endregion
        #region DATBAN
        public List<DATBAN> getDATBAN()
        {
            List<DATBAN> list = new List<DATBAN>();
            list = qlqa.DATBANs.Select(t => t).ToList<DATBAN>();
            return list;
        }
        #endregion
        #region CHITIETDATBAN
        public List<CHITIETDATBAN> getCHITIETDATBAN()
        {
            List<CHITIETDATBAN> list = new List<CHITIETDATBAN>();
            list = qlqa.CHITIETDATBANs.Select(t => t).ToList<CHITIETDATBAN>();
            return list;
        }
        #endregion
        #region GOIMON
        public List<GOIMON> getGOIMON()
        {
            List<GOIMON> list = new List<GOIMON>();
            list = qlqa.GOIMONs.Select(t => t).ToList<GOIMON>();
            return list;
        }
        #endregion
        #region CHITIETGOIMON
        public List<CHITIETGOIMON> getCHITIETGOIMON()
        {
            List<CHITIETGOIMON> list = new List<CHITIETGOIMON>();
            list = qlqa.CHITIETGOIMONs.Select(t => t).ToList<CHITIETGOIMON>();
            return list;
        }
        #endregion
        #region HOADON
        public List<HOADON> getHOADON()
        {
            List<HOADON> list = new List<HOADON>();
            list = qlqa.HOADONs.Select(t => t).ToList<HOADON>();
            return list;
        }
        #endregion
        #region NGUYENLIEU
        public List<NGUYENLIEU> getNGUYENLIEU()
        {
            List<NGUYENLIEU> list = new List<NGUYENLIEU>();
            list = qlqa.NGUYENLIEUs.Select(t => t).ToList<NGUYENLIEU>();
            return list;
        }
        public List<NGUYENLIEU> timNGUYENLIEU(string manl)
        {
            List<NGUYENLIEU> list = qlqa.NGUYENLIEUs.Where(t => t.MANL == manl).ToList();
            return list;
        }
        public void xoaNGUYENLIEU(string manl)
        {
            qlqa.NGUYENLIEU_XOA(manl);
            qlqa.SubmitChanges();
        }
        public void themNGUYENLIEU(string manl, string tennl)
        {
            NGUYENLIEU nl = new NGUYENLIEU();
            nl.MANL = manl;
            nl.TENNL = tennl;
            nl.SOLUONG = 0;
            qlqa.NGUYENLIEUs.InsertOnSubmit(nl);
            qlqa.SubmitChanges();
        }
        #endregion
    }
}
