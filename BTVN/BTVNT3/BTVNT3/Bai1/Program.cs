namespace Bai1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("nhap chieu Dai: ");
        int chieuDai = int.Parse(Console.ReadLine());
        Console.Write("nhap chieu Rong: ");
        int chieuRong = int.Parse(Console.ReadLine());
        for (int i = 0; i < chieuRong - 1; i++)
        {
            Console.Write('*');
            if (i == 0 || i == chieuRong - 2)
            {
                for (int j = 1; j < chieuRong - 1; j++)
                {
                    Console.Write('*');
                }
            }
            else
            {
                for (int j = 1; j < chieuRong - 1; j++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write('*');
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("VE HINH TAM GIAC CAN");
        Console.Write("nhap chieu dai canh: ");
        int canhBen = int.Parse(Console.ReadLine());
        for (int i = 0; i < canhBen; i++)
        {
            if (i == canhBen - 1)
            {
                for (int j = 0; j < (canhBen * 2) - 1; j++)
                {
                    Console.Write('*');
                }
            }
            else
            {
                if (i == 0)
                {
                    for (int z = 0; z < canhBen - 1; z++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < canhBen - i - 1; k++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                    for (int l = 0; l < 2 * i - 1; l++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                    Console.WriteLine();
                }
            }
        }
    }
}