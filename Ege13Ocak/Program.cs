using System;

namespace Ege13Ocak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
            
            Efe efe = new Efe();
            efe.JobSecondName = "engineer";

            Console.WriteLine("Efeni işi : " + efe.JobSecondName);
            
            Efe ege = new Efe();
            ege.JobSecondName = "student";
            
            Console.WriteLine("Egenin işi : " + efe.JobSecondName);
        }
    }
}
