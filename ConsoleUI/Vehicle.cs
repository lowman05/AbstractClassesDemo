using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        //stubbed out method
        public abstract void DriveAbstract(); 

        //using virtual means you don't have to use override if you choose not to
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This vehicle is dependable.");
        }
    }
}
