using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz.");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Grimiş olduğunuz sayı: " + sayi);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Hata " + ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("İşlem Tamamlandı.");
            //}
            //Console.ReadLine();
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
            Console.ReadLine();
            
            
        }
    }
}
