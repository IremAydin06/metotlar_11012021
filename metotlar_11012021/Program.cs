using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_11012021
{
    class Program
    {
        static void Main(string[] args)
        {
            //string.toCharArray() metodu: 

            String cümle = "Yazdığınız her kod sizi gülümsetsin. - Türkay ÜRKMEZ :) ";

            char[] harfler = cümle.ToCharArray(0, 3);
            foreach (char harf in harfler)
                Console.WriteLine(harf);
            /*çıktı:
           Y
           a
           z
          */

            Console.WriteLine("===================");

            //string.toContains()  metodu:

            String aranan1 = "kod";
            String aranan2 = "Gülümsetsin";

            Console.WriteLine(cümle.Contains(aranan1));
            Console.WriteLine(cümle.Contains(aranan2));
            /*çıktı:
             * True
             * False
             */

            Console.WriteLine("===================");

            //string.StartsWith()  metodu:

            Console.WriteLine(cümle.StartsWith("Y"));
            Console.WriteLine(cümle.StartsWith("m"));
            Console.WriteLine(cümle.StartsWith("y"));

            /*çıktı:
             * True
             * False
             * False
             */

            Console.WriteLine("===================");

            //string.Split()        metodu:

            string[] kelimeler = cümle.Split(' ');
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            /*çıktı: 
             Yazdığınız
             her
             kod
             sizi
             gülümsetsin.
             -
             Türkay
             ÜRKMEZ
             :)
             */

            Console.WriteLine("===================");

            //char.IsWhiteSpace     metodu:

            Console.WriteLine(Char.IsWhiteSpace(' '));      
            Console.WriteLine(Char.IsWhiteSpace(cümle, 5)); 
            /*çıktı:
             * True
               False 
            */

            Console.ReadKey();
        }
    }
}
