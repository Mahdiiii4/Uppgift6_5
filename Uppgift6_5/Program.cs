using System;

namespace uppgift6_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv ner text var på en rad");
            string ett = Console.ReadLine();
            string två = Console.ReadLine();
            Längst(ett, två);
        }
        static void Längst(string ett, string två)
        {
            if (ett.Length > två.Length)
            {
                Console.WriteLine("Första är längst");
                return;
            }
            else if (två.Length > ett.Length)
            {
                Console.WriteLine("Andra är längst");
                return;
            }
            else if (ett.Length == två.Length)
            {
                Console.WriteLine(ett);
                return;
            }
        }
    }
}
