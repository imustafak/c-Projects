using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli Fpnksiyon
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));
            //Extension Mtehodlar
            string ifade = "Zikriye Ürkmez Cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.ReadLine();

        }
        
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us<2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
    }
}
