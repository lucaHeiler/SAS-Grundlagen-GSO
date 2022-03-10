using System;

namespace Datenfelder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bitte geben sie die Anzahl der noten an ");


            //double abstand = Convert.ToDouble(Console.ReadLine());


            int n =10;
            int[] alle_noten = new int[n];
            int note = 0;

            int summe = 0;

            for(int index = 0; index < n; index = index + 1)
            {
                do
                {
                    Console.WriteLine("Geben sie eine Note ein!");
                    note = Convert.ToInt32(Console.ReadLine());
                    alle_noten[index]= note;

                    if (note <=6 & note >=1)
                    {
                        summe = summe + note;
                    }

                    if (note > 6 || note < 1)
                    {
                        Console.WriteLine("Falschen Wert eingegeben");
                    }
                } while (note > 6 || note < 1);


            }


            for (int index = 0; index < n; index = index + 1)
            {
                Console.WriteLine(alle_noten[index]);
            }







        }
    }
}
