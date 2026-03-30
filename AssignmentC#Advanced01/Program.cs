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

            #region Q03
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.

            //Answer:

            //What are multiple type parameters?

            //Multiple type parameters mean that a generic class (or method) can use more than one data type.

            //Instead of using one type like <T>, we can use two or more types like <TKey, TValue>.

            //This allows the class to store and work with different types of data at the same time.
            #endregion

            #region Q04
            //Q4: What is a generic method? Write Swap<T> method.
            //Answer:

            //What is a generic method?

            //A generic method is a method that works with different data types using a type parameter.

            //Instead of writing multiple methods for different types (int, string ,...),
            //we write one method using a placeholder type like <T>.

            //This makes the code reusable, flexible, and type-safe.

            //Example of Swap<T> method:

            //int x = 5;
            //int y = 10;

            //Swap<int>(ref x, ref y);

            //Console.WriteLine(x); // 10
            //Console.WriteLine(y); // 5
            #endregion

            #region Q05
            //Q5: Write a generic method FindMax<T> that finds maximum value.

            //The type T must implement IComparable<T> so we can compare values.

            //use example:
            //
            //int maxInt = Utility.FindMax(10, 20);
            //Console.WriteLine(maxInt); // 20

            //string maxString = Utility.FindMax("Ali", "Ziad");
            //Console.WriteLine(maxString); // Ziad

            #endregion

            #region Q06
            //Q6: What is a generic interface? Write IRepository<T>. 
            //Answer:

            //What is a generic interface?

            // A generic interface is an interface that can work with any data type without creating a separate interface for each type.
            // It allows flexibility so that the same interface can handle different types like int, string, or custom classes.

            // used :

            //IRepository<Customer> repo = new CustomerRepository();


            //repo.Add(new Customer { Id = 1, Name = "Ahmed" });
            //repo.Add(new Customer { Id = 2, Name = "Sara" });


            //foreach (var customer in repo.GetAll())
            //{
            //    Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
            //}


            //var singleCustomer = repo.GetById(1);
            //Console.WriteLine($"Single Customer: Id={singleCustomer.Id}, Name={singleCustomer.Name}");


            //repo.Remove(singleCustomer);

            //Console.WriteLine("After removal:");
            //foreach (var customer in repo.GetAll())
            //{
            //    Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
            //}
            #endregion

            #region Q07
            //Q7: What is the 'struct' constraint? Write an example.

            // Answer:

            //The struct constraint in C# is used in generics to specify that the type parameter must be a value type (like int, double, bool, or any user-defined struct).

            //This ensures that the generic type cannot be a reference type (like a class or string).

            //In short: "struct" = value type only.

            //use example:


            //Calculator<int> intCalc = new Calculator<int>();
            //Console.WriteLine("Sum of 5 + 10 = " + intCalc.Add(5, 10));


            //Calculator<double> doubleCalc = new Calculator<double>();
            //Console.WriteLine("Sum of 2.5 + 3.5 = " + doubleCalc.Add(2.5, 3.5));



            #endregion

            #region Q08
            //Q8: What is the 'class' constraint? Write an example.
            //Answer:
            //The class constraint in C# is used in generics to specify that the type parameter must be a reference type (like class objects or string).
            //This ensures that the generic type cannot be a value type (like int, double, or struct).

            //In short: "class" = reference type only.


            //used :


            //Repository<Customer> customerRepo = new Repository<Customer>();

            //customerRepo.Add(new Customer { Id = 1, Name = "Ahmed" });
            //customerRepo.Add(new Customer { Id = 2, Name = "Sara" });

            //Console.WriteLine("All Customers:");
            //foreach (var customer in customerRepo.GetAll())
            //{
            //    Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
            //}
            #endregion

            #region Q09
            //Q9: What is the 'new()' constraint? Write an example.
            //Answer:

            //The new() constraint in C# is used in generics to specify that the type parameter must have a public parameterless constructor.
            //This allows you to create instances of the type using new T() inside the generic class or method.

            //In short: "new()" = type must have a parameterless constructor.

            //used:
            
            //Factory<Customer> customerFactory = new Factory<Customer>();
            //Customer newCustomer = customerFactory.CreateInstance();

            
            //newCustomer.Id = 1;
            //newCustomer.Name = "Ahmed";

            //Console.WriteLine($"Customer: Id={newCustomer.Id}, Name={newCustomer.Name}");
            #endregion
        }
        #region Swap<T> method
        //public static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //} 
        #endregion

        #region MyRegion

        #endregion
    }
}
