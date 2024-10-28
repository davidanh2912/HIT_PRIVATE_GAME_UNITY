using System.Security.Cryptography.X509Certificates;

namespace BTVN1;

using System;

class Program
{
    static void Main(string[] args)
    {
        double A = 9, omegaA = 5 * Math.PI, tA = 2.125, T = 2 * Math.PI / omegaA;
        int t1 = (int)(tA / T); double tconLai = tA - t1 * T;
        double quangDuong = t1 * 4 * A + 2 * A * Math.Abs(Math.Cos(omegaA * tconLai + Math.PI / 2));
        Console.WriteLine("Quang duong vat A di chuyen duoc sau 2.125s la: " + quangDuong + "cm\n");
        Console.WriteLine("phuong trinh dao dong B: x(t)= acos(bπt+π/2) (cm)");
        Console.Write("\nnhap bien do cua vat dao dong B: ");
        double B = double.Parse(Console.ReadLine());
        Console.Write("nhap omega cua vat dao dong B = ?π: ");
        double omegaB = double.Parse(Console.ReadLine()) * Math.PI;
        Console.WriteLine("nhap thoi gian dao dong cua vat: ");
        double tB = double.Parse(Console.ReadLine());
        T = 2 * Math.PI / omegaB;
        int t2 = (int)(tB / T); double tconlaiB = tB - t2 * T;
        double quangDuongB = t2 * 4 * B + 2 * B * Math.Abs(Math.Cos(omegaB * tconlaiB + Math.PI / 2));
        Console.WriteLine($"Quang Duong vat B di chuyen duoc sau {tB}s la: {quangDuongB}cm\n");
        
    }
}