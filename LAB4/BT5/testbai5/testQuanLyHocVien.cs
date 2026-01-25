using NUnit.Framework;

namespace HocVienTests
{
    [TestFixture]
    public class QuanLyHocVienUnitTests
    {
        [Test]
        public void LayDanhSachHocBong_ReturnCorrectStudents()
        {
            var ql = new QuanLyHocVien();

            ql.ThemHocVien(new HocVien("HV01", "A", "HCM", 9, 9, 9));
            ql.ThemHocVien(new HocVien("HV02", "B", "HN", 7, 8, 9));
            ql.ThemHocVien(new HocVien("HV03", "C", "DN", 8, 8, 8));
            ql.ThemHocVien(new HocVien("HV04", "D", "CT", 9, 4, 9));

            var danhSachHocBong = ql.LayDanhSachHocBong();

            Assert.That(danhSachHocBong.Count, Is.EqualTo(2));
        }
    }
}
