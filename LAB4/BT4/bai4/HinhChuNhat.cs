using System;

public class HinhChuNhat
{
    public Diem TopLeft { get; }
    public Diem BottomRight { get; }

    public HinhChuNhat(Diem topLeft, Diem bottomRight)
    {
        if (topLeft.X >= bottomRight.X || topLeft.Y <= bottomRight.Y)
            throw new ArgumentException("Invalid rectangle coordinates");

        TopLeft = topLeft;
        BottomRight = bottomRight;
    }

    // Tính diện tích
    public double TinhDienTich()
    {
        double width = BottomRight.X - TopLeft.X;
        double height = TopLeft.Y - BottomRight.Y;
        return width * height;
    }

    // Kiểm tra giao nhau
    public bool CoGiaoNhau(HinhChuNhat other)
    {
        // Không giao nếu 1 hình nằm hoàn toàn bên trái/phải/trên/dưới hình kia
        if (this.BottomRight.X <= other.TopLeft.X ||
            this.TopLeft.X >= other.BottomRight.X ||
            this.BottomRight.Y >= other.TopLeft.Y ||
            this.TopLeft.Y <= other.BottomRight.Y)
        {
            return false;
        }

        return true;
    }
}
