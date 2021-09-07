using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;

namespace UnitTest_QLNhanVien
{
    [TestClass]
    public class UnitTest1
    {
        Handle_QLNhanVien qlnv = new Handle_QLNhanVien();
        //Test SDT
        [TestMethod]
        public void TestKiemTraSDT_KhongHopLe()
        {
            bool Result_Actual = qlnv.KiemTraSDT("4948462040");
            bool Result_Expect = false;
            Assert.AreEqual(Result_Expect, Result_Actual);

        }

        [TestMethod]
        public void TestKiemTraSDT_HopLe()
        {
            bool Result_Actual = qlnv.KiemTraSDT("0948462040");
            bool Result_Expect = true;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
        //Test CMND
        
        [TestMethod]
        public void TestKiemTraCNMD_KhongHopLe()
        {
            bool Result_Actual = qlnv.KiemTraCMND("2616320000");
            bool Result_Expect = false;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
        [TestMethod]
        public void TestKiemTraCNMD_HopLe()
        {
            bool Result_Actual = qlnv.KiemTraCMND("261632890");
            bool Result_Expect = true;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
        //Test Password
        [TestMethod]
        public void TestKiemTraMatKhau_HopLe()
        {
            bool Result_Actual = qlnv.KiemTraMatKhau("nhuy7");
            bool Result_Expect = true;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
        [TestMethod]
        public void TestKiemTraMatKhau_KhongHopLe()
        {
            bool Result_Actual = qlnv.KiemTraMatKhau("phanmainhuy");
            bool Result_Expect = false;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
    }
}
