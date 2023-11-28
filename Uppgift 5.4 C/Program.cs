using System;
namespace Uppgift_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Olle", "Theo", "Alfred", "Emil", "Markus" };

            Array.Sort(namn);

           foreach (string x in namn)
            {
                Console.WriteLine(x);
            }

            
        }
    }
}