using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Handle_QLKhachHang
    {
        DataClasses1DataContext QLQA = new DataClasses1DataContext();
        public Handle_QLKhachHang() { }
        public List<KHACHHANG> GetKhachHang()
        {
            return QLQA.KHACHHANGs.Select(k => k).ToList<KHACHHANG>();
        }
        //Kiem tra gioi tinh
        public bool KiemTraGioiTinh(string gioitinh)
        {
            if(gioitinh == "Nam")
            {
                return true;
            }
            return false;
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

        //Kiem tra trung MaKH
        public bool KiemtratrungMaKH(string pMa)
        {
            if (QLQA.KHACHHANGs.Count(c => c.MAKH == pMa) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }
        //Kiem tra trung SDT
        public bool KiemtratrungSDT(string pSDT)
        {
            if (QLQA.KHACHHANGs.Count(c => c.SDT == pSDT) > 0)
            {
                return true; //trung
            }
            return false; //khong trung
        }

        //Them
        public void ThemKH(string pMa, string pTen, string pSDT, string pNgaySinh, string pGioiTinh, int pDiem)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.MAKH = pMa;
            kh.TENKH = pTen;
            kh.SDT = pSDT;
            kh.NGAYSINH = DateTime.Parse(pNgaySinh);
            kh.GIOITINH = pGioiTinh;
            kh.DIEM = pDiem;
 
            QLQA.KHACHHANGs.InsertOnSubmit(kh);
            QLQA.SubmitChanges();
        }

        //Xoa
        public void XoaNV(string pMa)
        {
            KHACHHANG kh = QLQA.KHACHHANGs.Where(m => m.MAKH == pMa).FirstOrDefault();

            if (kh != null)
            {
                QLQA.KHACHHANGs.DeleteOnSubmit(kh);
                QLQA.SubmitChanges();
            }
        }

        //Sua
        public void SuaKH(string pMa, string pTen, string pSDT, string pNgaySinh, string pGioiTinh)
        {
            KHACHHANG kh = QLQA.KHACHHANGs.Where(m => m.MAKH == pMa).FirstOrDefault();
            if (kh != null)
            {
                kh.TENKH = pTen;
                kh.NGAYSINH = DateTime.Parse(pNgaySinh);
                kh.SDT = pSDT;
                kh.GIOITINH = pGioiTinh;

                QLQA.SubmitChanges();
            }
        }

    }
}
