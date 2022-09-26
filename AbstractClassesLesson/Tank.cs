using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLesson
{
    //by inheriting from Vehicle this class must have Drive, Reverse.  It doesn't care how you do it
    // just that it must have everything that is in the abstract class vehicle.  
    public class Tank : Vehicle
    {
        public override void Drive() //use override because it allows us the flexiblity to say that this
                                    //tank class will use it own drive method.  
        {
            Console.WriteLine($"Tank is on the move!");
        }

        public override void Reverse()
        {
            Console.WriteLine($"Tank is now reversing");
        }

        public override void Operate() // tank can choice if it wants to use what is in this scope or what
            //is in the vehicle Operate scope.  
        {
            Console.WriteLine($"This is Tanks Operation");
        }

    }
}
