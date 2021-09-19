using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            string a = Console.ReadLine();
            if (float.Parse(a) > 6.28 || float.Parse(a) < 0)
            {
                Console.WriteLine($"число {a} больше 6.28");
                return;
            }
            double Res = (float.Parse(a) / 3.14) * 180;

            Console.WriteLine($"{Res} градусов");

        }
    }
 }
