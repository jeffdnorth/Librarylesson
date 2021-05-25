using Librarylesson;
using System;

namespace TestLibraryLeson
{
    class Program
    {
        static void Main(string[] args)
        {
            //when you have static methods do not need to creat instance of class instead use
            // class name.method name
            var OnePlusTwo = MathLib.Add(1, 2);
            var ans = MathLib.Modulo(5, 3);
        }
        //method
        
        
       
    }
}
