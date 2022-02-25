using System;
using System.Runtime.CompilerServices;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int Agg = int.Parse(Console.ReadLine());
            Child kid = new Child(name, Agg);
            Console.WriteLine(kid);
        }
    }
}