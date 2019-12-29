using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet a = new Pet("Garfield", 5, " fat cat");
            Console.WriteLine(a);
            a.SetOwner("Jon");
            Console.WriteLine(a);
            a.Train();
            Console.WriteLine(a);
            

            Pet b = new Pet("Marnie", 3, " dalmation");
            b.SetOwner("Jon");

            Pet c = new Pet("Garfield", 5, " fat cat");
            c.Train();

            Pet d = new Pet("Garfield", 5, " fat cat");

            List<Pet> pets = new List<Pet>() { a, b, c, d };
            foreach (Pet p in pets)
            {
                if(p.Owner == "Jon")
                    Console.WriteLine(p.Name);
            }

        }
    }
}
