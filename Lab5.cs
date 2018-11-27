using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Scope- The variable that is declared onside a method. 
           Static-determines whether we can call it from the same
             file as Main method or without creating a object.
             The difference between static and non-static is that static can only access
             static, but not the non-static fields.  And the non-static methods "this" parameter is hidden
             but allows you to access it.
             Method Name- should make the method self-explanatory
             Parameters-used to pass values or variable references to methods.
             The parameters of a method get their actual values from the arguements
             that are specified when the method is envoked.  Enclosed in parentheses
             and separated by commas.
             Method body-A group of statments that together preform a task.
             Return Type- The type listed before the method name.

            */

            public string Name { get; set; }

        Add Bark() method;
            Add DoTrick("fetch") method;

            Dog myDog = new Dog();
        myDog.Name = "Fido";

            myDog.Bark();
            myDog.DoTrick("fetch");

            Console.WriteLine("{Fido} is Barking...");
            Console.WriteLine("{"Fido"} is so smart!  {Fido} is doing a {"fetch"});

           Add DoTrick("sit") method;
            Console.WriteLine("{"Fido"} is smart! {"Fido"} is doing the "sit"", trickName sit);)




        }
    }
}
