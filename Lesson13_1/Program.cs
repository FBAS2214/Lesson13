using System;
using System.Text;

namespace Lesson13_1
{
    interface ICell { }
    class Base { }
    
    
    class Apple : Base, ICell { }
    class Mi : Base { }
    class Samsung : ICell { }




    // class, struct

    class Entity<T> where T : Base, new(){}

    class Any<T> where T : ICell, new() { }

    class Some<T, B> where T : B{}



    class Program
    {
        static void Main()
        {
            Entity<Apple> entity = new();
            Some<Mi, Base> some = new();
            Any<Samsung> any = new();
        }


        // class
        // struct
        // new()
        // base class name
        // interface name
        // U - two arguments

        // default
        // not null
        // unmanaged
    }
}