using System;
using System.Text;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            StringbuilderMethod();
        }

      private static void StringbuilderMethod()
        {
            Console.Write("Introduceti numarul de linii N=");
            string nrAsString = Console.ReadLine();

            if (!int.TryParse(nrAsString, out int nr))
            {
                Console.WriteLine("Nu ati introdus un numar!");
                return;
            }

            StringBuilder s = new StringBuilder("text de pornire \n");

            for (int i = 0; i < nr; i++)
            {
                s.AppendLine($"Line {i + 1}");
                //s += $"Line {i+1} \n ";
            }
            //s += $"Added a total of {nr} lines";
            s.AppendLine($"Added a total of {nr} lines");

            Console.WriteLine(s.ToString());
        }
    }
}
