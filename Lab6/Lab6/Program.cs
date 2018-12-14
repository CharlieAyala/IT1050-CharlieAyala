// task 2
// p[0], p[1], p[2], p[3]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 3
            string[] months = { "1st January", "2nd February", "3rd March", "4th April", "5th May", "6th June", "7th July", "8th August", "9th september", "10th October", "11th November", "12th December" };
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months[i]);
                Console.ReadLine();
            }

            //task 4
            String[] seasons = { "spring", "Summer", "Fall", "Winter" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
                Console.ReadLine();
            }
            // task 5

            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100);
            }

            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());
                Console.ReadLine();
            }

            // task 6
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
                Console.ReadLine();
            }

            // task 7
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
                Console.ReadLine();
            }

            // task 8
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0, 2}. {1}", i, names[i]);
                i++;
                Console.ReadLine();
            }

        }

    }
}
