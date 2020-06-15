using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            //Console.WriteLine($"Before:");
            //foreach (Flavor flavor in availableFlavors)
            //{

            //    Console.WriteLine(flavor.Name);
            //}

            //Console.WriteLine("");

            availableFlavors.Sort(new FlavorComparer());
            Console.WriteLine($"After: ");

            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            //Console.WriteLine($"Before:");
            //foreach (Cone cone in availableCones)
            //{

            //    Console.WriteLine(cone.Cost);
            //}

            //Console.WriteLine("");

            availableCones.Sort(new ConeComparer());
            Console.WriteLine($"After: ");

            foreach (Cone cone in availableCones)
            {
                Console.WriteLine(cone.Cost);
            }



            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.


        }
    }
}
