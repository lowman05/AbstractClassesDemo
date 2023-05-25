using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car rabbit = new Car()
            {
                Year = "1999",
                Make = "Volkswagen",
                Model = "Rabbit",
                HasGlovebox = true,
            };

            Motorcycle kawasaki = new Motorcycle()
            {
                Year = "2015",
                Make = "Kawasaki",
                Model = "Vulcan",
                HasKickstand = true,
            };

            Vehicle minivan = new Car()
            {
                Year = "2015",
                Make = "Kia",
                Model = "Sedona",
                HasGlovebox = true,
            };

            Vehicle utility = new Car()
            {
                Year = "1985",
                Make = "Ford",
                Model = "Bronco",
                HasGlovebox = true,
            };

            vehicles.Add( rabbit );
            vehicles.Add( kawasaki );
            vehicles.Add( utility );    
            vehicles.Add( minivan );    

            foreach ( var vehicle in vehicles )
            {
                Console.WriteLine($"This {vehicle.Year} {vehicle.Make} {vehicle.Model} is available!");
            }

            rabbit.DriveAbstract(); 
            rabbit.DriveVirtual();
            kawasaki.DriveAbstract();
            kawasaki.DriveVirtual();

                      
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
