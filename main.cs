using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("������� �����");
        string a = Console.ReadLine();
        if (float.Parse(a) > 6.28 || float.Parse(a) < 0)
        {
            Console.WriteLine($"����� {a} ������ 6.28");
            return;
        }
        double Res = (float.Parse(a) / 3.14) * 180;

        Console.WriteLine($"{Res} ��������");

    }
}