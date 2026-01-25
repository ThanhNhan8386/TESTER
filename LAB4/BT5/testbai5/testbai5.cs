using NUnit.Framework;
using System;

namespace HocVienTests
{
    [TestFixture]
    public class HocVienUnitTests
    {
        /* ---------- Constructor Tests ---------- */

        [Test]
        public void Constructor_InvalidScore_ThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
                new HocVien("HV01", "Nguyen Van A", "HCM", 11, 8, 9));
        }

        /* ---------- Scholarship Criteria Tests ---------- */

        [Test]
        public void DuDieuKienHocBong_AllScoresValid_ReturnTrue()
        {
            var hv = new HocVien("HV02", "Tran Thi B", "HN", 8, 9, 8);

            Assert.That(hv.DuDieuKienHocBong(), Is.True);
        }

        [Test]
        public void DuDieuKienHocBong_AverageBelow8_ReturnFalse()
        {
            var hv = new HocVien("HV03", "Le Van C", "DN", 7, 8, 8);

            Assert.That(hv.DuDieuKienHocBong(), Is.False);
        }

        [Test]
        public void DuDieuKienHocBong_HasScoreBelow5_ReturnFalse()
        {
            var hv = new HocVien("HV04", "Pham Thi D", "CT", 9, 4, 9);

            Assert.That(hv.DuDieuKienHocBong(), Is.False);
        }
    }
}
