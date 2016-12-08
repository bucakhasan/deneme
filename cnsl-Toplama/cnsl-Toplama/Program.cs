using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen iki sayının toplamını hesaplayıp ekranda gösteren console uygulamasını yazınız.
            Console.Write("1. sayı girin : ");
            string A = Console.ReadLine();
            Console.Write("2. sayı girin : ");
            string B = Console.ReadLine();
            //Console.Write(A + B);
            int S1, S2;
            S1 = int.Parse(A);
            S2 = int.Parse(B);
            //Console.Write("Toplam = " + (S1 + S2));
            int T = S1 + S2;
            //Console.Write("Toplam = " + T);
            //Console.Write("1.sayı = {0}, 2.sayı = {1}", S1, S2);
            Console.Write("{0} + {1} = {2}", S1, S2, S1 + S2);
            Console.ReadKey();
        }
    }
}
