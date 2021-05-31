using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: \n");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());

            }
            finally
            {
                // hata alsın ya da almasın burası gösterilir.
                Console.WriteLine("İşlem Tamamlandı..");

            }

            try
            {
                //parse=> string ifadeleri int e çevirir
                //int a=int.Parse(null);
                int b=int.Parse("test");

            }
            catch (ArgumentNullException ex)
            {
                
                 Console.WriteLine("Boş değer girdiniz\n");
                   Console.WriteLine(ex);
            }

            catch(FormatException ex2)
            {
                Console.WriteLine("Veri tipi uygun değil\n");
                   Console.WriteLine(ex2);
                

            }



        }
    }
}
