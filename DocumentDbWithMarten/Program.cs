using System;

namespace DocumentDbWithMarten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dc = new DataConnection();
            Console.WriteLine(dc.GetValueString());
        }
    }
}