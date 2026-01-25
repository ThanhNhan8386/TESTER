using System.Collections.Generic;
using System.Linq;

public class QuanLyHocVien
{
    private readonly List<HocVien> danhSach = new List<HocVien>();

    public void ThemHocVien(HocVien hv)
    {
        danhSach.Add(hv);
    }

    public List<HocVien> LayDanhSachHocBong()
    {
        return danhSach.Where(hv => hv.DuDieuKienHocBong()).ToList();
    }
}
