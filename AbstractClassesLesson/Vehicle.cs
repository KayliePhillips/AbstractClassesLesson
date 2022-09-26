using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLesson
{
    public abstract class Vehicle
    {
        public abstract void Drive(); //when you inherite this class it must have it own Drive with a scope

        public abstract void Reverse();

        public virtual void Operate() //virtual says that the abstract class vehicle does have implementation
            //for this Operate method.  Any class that inherites the Vehicle class can choice to use this method
            // or one of its own.  
        {
            Console.WriteLine($"This vehicle operates");
        }


    }
}
