﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5435
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 5, 7, 1, 9, 5, 3, 5 };
            int sum = omas.Sum();
            Console.WriteLine("Сумма всех чисел массива:" + sum);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
