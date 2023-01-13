using System;

namespace Ege13Ocak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
            
            Efe efe = new Efe();
            efe.Job = "engineer";

            Console.WriteLine("Efeni işi : " + efe.Job);
            
            Efe ege = new Efe();
            ege.Job = "student";
            
            Console.WriteLine("Egenin işi : " + efe.Job);
        }
    }
}
