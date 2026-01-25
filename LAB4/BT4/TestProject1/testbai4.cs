using NUnit.Framework;
using System;

namespace HinhChuNhatTests
{
    [TestFixture]
    public class HinhChuNhatUnitTests
    {
        /* ---------- Constructor Tests ---------- */

        [Test]
        public void Constructor_InvalidCoordinates_ThrowException()
        {
            var p1 = new Diem(5, 5);
            var p2 = new Diem(3, 7);

            Assert.Throws<ArgumentException>(() => new HinhChuNhat(p1, p2));
        }

        [Test]
        public void Constructor_ValidCoordinates_CreateSuccessfully()
        {
            var p1 = new Diem(0, 10);
            var p2 = new Diem(5, 0);

            Assert.DoesNotThrow(() => new HinhChuNhat(p1, p2));
        }

        /* ---------- Area Tests ---------- */

        [Test]
        public void TinhDienTich_ReturnCorrectArea()
        {
            var rect = new HinhChuNhat(
                new Diem(0, 10),
                new Diem(5, 0)
            );

            var area = rect.TinhDienTich();

            Assert.That(area, Is.EqualTo(50));
        }

        /* ---------- Intersection Tests ---------- */

        [Test]
        public void CoGiaoNhau_Overlap_ReturnTrue()
        {
            var r1 = new HinhChuNhat(
                new Diem(0, 10),
                new Diem(6, 0)
            );

            var r2 = new HinhChuNhat(
                new Diem(4, 8),
                new Diem(10, 2)
            );

            Assert.That(r1.CoGiaoNhau(r2), Is.True);
        }

        [Test]
        public void CoGiaoNhau_NoOverlap_ReturnFalse()
        {
            var r1 = new HinhChuNhat(
                new Diem(0, 10),
                new Diem(4, 0)
            );

            var r2 = new HinhChuNhat(
                new Diem(5, 8),
                new Diem(9, 2)
            );

            Assert.That(r1.CoGiaoNhau(r2), Is.False);
        }

        [Test]
        public void CoGiaoNhau_TouchingEdge_ReturnFalse()
        {
            var r1 = new HinhChuNhat(
                new Diem(0, 10),
                new Diem(5, 0)
            );

            var r2 = new HinhChuNhat(
                new Diem(5, 8),
                new Diem(10, 2)
            );

            Assert.That(r1.CoGiaoNhau(r2), Is.False);
        }
    }
}
