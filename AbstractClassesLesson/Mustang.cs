using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLesson
{
    public class Mustang : Vehicle
    {
        public Mustang()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"Mustang is hauling!");
        }

        public override void Reverse()
        {
            Console.WriteLine($"Mustang is reversing to peel out");
        }

    }
}
