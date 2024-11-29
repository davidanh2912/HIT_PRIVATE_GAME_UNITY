namespace BaiTap2;

public class SinhVien
{
    public int maSinhVien;
    public string hoVaTen;
    public float diemLT, diemTH;


    public string HoTen { get; set; }
    public float DiemLT { get; set; }
    public float DiemTH { get; set; }

    public SinhVien()
    {
    }

    public SinhVien(int maSinhVien, string hoTen, float diemLT, float diemTH)
    {
        this.maSinhVien = maSinhVien;
        this.hoVaTen = hoTen;
        this.diemLT = diemLT;
        this.diemTH = diemTH;

    }

    public double diemTB()
    {
        return (diemLT * 40 / 100 )+ (diemTH * 60 / 100 );
    }

    public void toString()
    {
        
    }
}