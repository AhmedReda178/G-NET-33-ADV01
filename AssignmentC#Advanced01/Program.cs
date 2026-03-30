using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentC_Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Q1: What is a generic class? Why use generics?

            //Answer:

            //What is a generic class?

            //A generic class is a class that is defined with a placeholder type (called a type parameter),
            //allowing it to work with different data types without rewriting the code.

            //Instead of specifying a concrete data type (like int or string), we use a generic type such as <T>,
            //which can be replaced with any type when creating an object.

            //Why use generics?

            //01.Code Reusability: You can write one class or method and use it with multiple data types.

            //02.Type Safety: Errors are caught at compile time instead of runtime.

            //03.Performance: No need for boxing/unboxing when working with value types.

            //04.Readability: Reduces duplication and makes the code easier to maintain.



            #endregion

            #region Q02
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Used Example:
            //Container<int> c1 = new Container<int>();
            //c1.Add(100);
            //Console.WriteLine(c1.Get());

            //Container<string> c2 = new Container<string>();
            //c2.Add("Ahmed Reda");
            //Console.WriteLine(c2.Get());
            #endregion
        }
    }
}
