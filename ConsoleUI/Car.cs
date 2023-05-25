using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle 
    {
        public Car() 
        { 
        }
        public bool HasGlovebox { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine($"It is {HasGlovebox} that this car has a glovebox.");
        }
        
    }
}
