﻿
using System;
namespace Ders
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi giriniz.");
            string surname = Console.ReadLine();
            Console.WriteLine(name +" "+ surname);
        }
    }
}
