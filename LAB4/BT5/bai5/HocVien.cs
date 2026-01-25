using System;
using System.Linq;

public class HocVien
{
    public string MaSo { get; }
    public string HoTen { get; }
    public string QueQuan { get; }
    public double[] Diem { get; }

    public HocVien(string maSo, string hoTen, string queQuan, double diem1, double diem2, double diem3)
    {
        if (new[] { diem1, diem2, diem3 }.Any(d => d < 0 || d > 10))
            throw new ArgumentException("Điểm không hợp lệ");

        MaSo = maSo;
        HoTen = hoTen;
        QueQuan = queQuan;
        Diem = new[] { diem1, diem2, diem3 };
    }

    public double DiemTrungBinh()
    {
        return Diem.Average();
    }

    public bool DuDieuKienHocBong()
    {
        return DiemTrungBinh() >= 8.0 && Diem.All(d => d >= 5.0);
    }
}
