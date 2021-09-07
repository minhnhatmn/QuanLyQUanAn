using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
namespace BUS
{
    public class Handle_QLNhanVien
    { 
        DataClasses1DataContext QLQA = new DataClasses1DataContext();

        public Handle_QLNhanVien() { }
        public List<NHANVIEN> GetNhanVien()
        {
            return QLQA.NHANVIENs.Select(k => k).ToList<NHANVIEN>();
        }

        //kiem tra sdt
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
        public bool KiemTraCMND (string cmnd)
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

        //Kiem tra gioi tinh
        public bool KiemTraGioiTinh(string gioitinh)
        {
            if (gioitinh == "Nam")
            {
                return true;
            }
            return false;
        }
        //Kiem tra trung Ma
        public bool KiemTraTrungMaNV(string pMa)
        {
            if (QLQA.NHANVIENs.Count(c => c.MANV == pMa) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Kiem tra trung SDT
        public bool KiemTraTrungSDT(string pSDT)
        {
            if (QLQA.NHANVIENs.Count(c => c.SDT == pSDT) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Kiem tra trung CMND
        public bool KiemTraTrungCMND(int pCMND)
        {
            if (QLQA.NHANVIENs.Count(c => c.CMND == pCMND) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Kiem tra mat khau
        public bool KiemTraMatKhau(string mk)
        {
            bool kieuso = false;
            bool kieuchu = false;
            if (mk.Length < 5 || mk.Length > 15)
                return false;
            foreach (char c in mk)
            {
                if (char.IsDigit(c))
                    kieuso = true;
                if (char.IsLetter(c))
                    kieuchu = true;
                if (char.IsSymbol(c))
                    return false;
            }
            if (kieuso && kieuchu)
                return true;
            return false;
        }

        public List<NHANVIEN> timNHANVIEN(string manv)
        {
            List<NHANVIEN> list = QLQA.NHANVIENs.Where(t => t.MANV == manv).ToList();
            return list;
        }
        public int themNHANVIEN(string manv, string tennv, int cmnd, string sdt, DateTime ngaysinh, string gioitinh, string chucvu, string matkhau, string diachi)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = manv;
                nv.TENHANVIEN = tennv;
                nv.CMND = cmnd;
                nv.SDT = sdt;
                nv.NGAYSINH = ngaysinh;
                nv.GIOITINH = gioitinh;
                nv.CHUCVU = chucvu;
                nv.MATKHAU = matkhau;
                nv.DIACHI = diachi;
                QLQA.NHANVIENs.InsertOnSubmit(nv);
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public void xoaNHANVIEN(string manv)
        {
            QLQA.NHANVIEN_XOA(manv);
            QLQA.SubmitChanges();
        }
        //Kiem tra trung SDT
        public bool KiemTraSuaSDT(string pSDT)
        {
            if (QLQA.NHANVIENs.Count(c => c.SDT == pSDT) > 1)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Kiem tra trung CMND
        public bool KiemTraSuaCMND(int pCMND)
        {
            if (QLQA.NHANVIENs.Count(c => c.CMND == pCMND) > 1)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Sua
        public int suaNHANVIEN(string manv, string tennv, int cmnd, string sdt, DateTime ngaysinh, string gioitinh, string chucvu, string matkhau, string diachi)
        {
            try
            {
                NHANVIEN nv = QLQA.NHANVIENs.Where(t => t.MANV == manv).FirstOrDefault();
                //nv.MANV = manv;
                nv.TENHANVIEN = tennv;
                nv.CMND = cmnd;
                nv.SDT = sdt;
                nv.NGAYSINH = ngaysinh;
                nv.GIOITINH = gioitinh;
                nv.CHUCVU = chucvu;
                nv.MATKHAU = matkhau;
                nv.DIACHI = diachi;
                QLQA.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int ktsuaSDT(string sdt, string manv)
        {
            NHANVIEN nv = QLQA.NHANVIENs.Where(t => t.SDT == sdt).FirstOrDefault();
            if (nv==null)
            {
                return 1;
            }
            else 
            {
                if (nv.MANV==manv)
                {
                    return 1;
                }
            }
            return -1;
        }
        public int ktsuaCMND(int cmnd, string manv)
        {
            NHANVIEN nv = QLQA.NHANVIENs.Where(t => t.CMND == cmnd).FirstOrDefault();
            if (nv == null)
            {
                return 1;
            }
            else
            {
                if (nv.MANV == manv)
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
