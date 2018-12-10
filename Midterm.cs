using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /* What are three types of control structures?
             * The Loops, Ifs, and Switch.  
             * The Loop structure has three different types, the For loop
             * the While loop, and the Do While loop.  
             * The If's control structure has 2 different statements.  The 
             * If-else statment, the If-else-if ladder statement.
             * And finally the switch statement.*/

            


           bool keepLooping = true;
            for (int i = 0; i < 5000; i++)
            {
               Console.WriteLine(i);
            }
            while (keepLooping == true)
                Console.ReadLine();

            {
                int i = 2;

                while (i< 129)
                {
                    Console.WriteLine("Value of i: [{0}]", i++);

                    i++;
                }

            }
            {
                for (int i = 0; i < 50; i++)
                    Console.WriteLine("Value of i: {0},", i);
            }
            {
                for (int i = 1; i< 23; i++)
                {
                    Console.WriteLine("{0}", i++);
                }

                {
                    int n = 8;
                    int i = 10; // initialize
                    do
                    {
                        Console.Write("*");
                        i++; // update!
                    } while (i < n); // test condition
                    //The outcome for this is a *
                    //If a different code was used it would be a pyramid of *'s

                }
                {


                    
                    bool tornadoWarning = true;
                    bool icyRain = true;
                    bool Letsgooutside = false;
                    bool result;
                    result = tornadoWarning | icyRain; // true
                    result = icyRain | Letsgooutside; // true
                    result = tornadoWarning | Letsgooutside; // true
                    result = Letsgooutside; // false
                    
                    // You can use different types of boolean structures like the or operator or the and operator 






                }

            }

        }
    }
}
