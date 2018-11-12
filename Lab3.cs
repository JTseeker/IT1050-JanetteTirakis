using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        private const double V = 1.8;
        private const int V1 = 32;
        private static int Celsius;

        static void Main(string[] args)
        {
            /*What is the if single selection statement 
             * and what is the while repetition statment?
             * The if single selection statment is a 
             * statment where if one outcome comes true, 
             * then a action will happen.  And is displayed as
             * a kite.  While the while repetition statement
             allows you to specify that a application should repeat 
             a action.  So it can do more then one action.*/
            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit) ;

            Console.WriteLine("SLOW DOWN");

            {
                { { int x = 8;
                        if (x > 8) ;
                        Console.WriteLine("It is True"); }
                else ;
                    Console.WriteLine("It is False"); }

            }
            {

                Console.WriteLine("Converting Fahrenheit to Celsius");
                int Fahrenheit = 82;
                int Celsius = 28;

                Fahrenheit = Program.V(Celsius) + V1;

                if (Fahrenheit <= 40)
                    Console.WriteLine("It is cold");
                if (Fahrenheit >= 90)
                    Console.WriteLine("It is hot");

            }
            { for (int i = 1; i < 10; i++)
                    Console.WriteLine("Value of i: {1}", i);

                for (int i = 60; i > 20; i--)
                    Console.WriteLine("Value of i: {60}", i);

                for (int i = 10; i < 20; i++)
                    Console.WriteLine("Value of i: {2}", i);
            }
            
        
    
