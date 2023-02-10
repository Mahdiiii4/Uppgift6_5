using System;

namespace uppgift6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Längst("test12", "test12");
            Längst("122", "121");
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