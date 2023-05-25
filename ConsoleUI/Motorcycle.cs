using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasKickstand { get; set; }
        
        public override void DriveAbstract()
        {
            Console.WriteLine($"It is {HasKickstand} that this motorcycle has a kickstand.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is just for cruising");  
        }
    }
}
