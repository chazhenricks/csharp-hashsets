using System;
using System.Collections.Generic;
namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a set of like types
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Countach");
            Showroom.Add("Viper");
            Showroom.Add("Corvette");
            Showroom.Add("Fit");

            //cannot have the same type in the hashset at one time
            Showroom.Add("Countach");


            HashSet<string> UsedCars = new HashSet<string>();
            UsedCars.Add("Pinto");
            UsedCars.Add("Nova");

            //UnionWith will merge two HashSets
            Showroom.UnionWith(UsedCars);

            //Remove will remove an item
            Showroom.Remove("Nova");



            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Mustang");
            Junkyard.Add("Volvo");
            Junkyard.Add("Countach");

            Junkyard.Remove("Countach");

            Showroom.UnionWith(Junkyard);

             foreach (string car in Showroom){
                Console.WriteLine(car);
            }

        }
    }
}
