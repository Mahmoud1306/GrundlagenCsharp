using System;

namespace Array_Noten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            double summe = 0;

            int[] Noten = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Gebben sie die Note {i} ein : ");
                Noten[i] = Convert.ToInt32(Console.ReadLine());
                summe = summe + Noten[i];
            }
            
            Console.WriteLine("Das sind ihre B");
            for (int p = 0; p < Noten.Length; p++)
            {
                Console.WriteLine(Noten[p]);
            }

            Console.WriteLine("Der Durschnittt ist");
            Console.WriteLine(summe/n);





        }
    }
}
