namespace BTVN2;

class Program
{
    static void Main(string[] args)
    {
        double v0 = 20, goc = 30 * Math.PI / 180, g = 9.8;
        double v0x = v0 * Math.Cos(goc);
        double v0y = v0 * Math.Sin(goc);
        double tMax = v0y / g;
        double H = v0y * tMax - 0.5 * g * Math.Pow(tMax, 2);
        double T = 2 * tMax;
        double qDuong = v0x * T;
        Console.WriteLine("Van toc ban dau theo phuong ngang: v0x = {0}", v0x);
        Console.WriteLine("Van toc ban dau theo phuong ngang: v0x = {0}", v0y);
        Console.WriteLine("Thoi gian vat len den diem cao nhat la: tMax = {0}", tMax);
        Console.WriteLine("Chieu cao cuc dai ma vat dat duoc la: H = {0}", H);
        Console.WriteLine("Quang duong ngang ma vat di duoc khi tro lai mat dat la: qDuong = {0}", qDuong);
    }

}