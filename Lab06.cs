using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A one-dimensional array p contains four elements.  The array access expressions to
             * access each of the elements in p are [0], [1], [2] and [3].
             */

            {string[] months = new string [11];
                months[0] = "January";
                months[1] = "Febuary";
                months[2] = "March";
                months[3] = "April";
                months[4] = "May";
                months[5] = "June";
                months[6] = "July";
                months[7] = "August";
                months[8] = "September";
                months[9] = "October";
                months[10] = "November";
                months[11] = "December";
                foreach (string Month in months)
                { 
                Console.WriteLine("The Month" + months);
            }
                Console.ReadLine();
                    }
            { 

                string[] arr = new string[3];
                arr[0] = "Winter";
                arr[1] = "Spring";
                arr[2] = "Summer";
                arr[3] = "Fall";
                foreach (string Season in arr)
                {
                    Console.WriteLine("The Element" + Season);
                }
                Console.ReadLine();

            }

            Random random = new Random();
            int randomNumber;
            
            randomNumber = random.Next(0, 100);
            randomNumber = random.Next(101, 200);
            randomNumber = random.Next(201, 300);
            randomNumber = random.Next(301, 400);
            randomNumber = random.Next(401, 500);
            randomNumber = random.Next(501, 600);
            randomNumber = random.Next(601, 700);
            randomNumber = random.Next(701, 800);
            randomNumber = random.Next(801, 900);
            randomNumber = random.Next(901, 1000);

            

            string[] names = new string[4];

            names[0] = "Al Dente";
            names[1] = "Anna Graham";
            names[2] = "Earle Bird";
            names[3] = "Ginger Rayle";
            names[4] = "Iona Ford";
            {
                Console.WriteLine(names[0]);
            }
            Console.WriteLine("{0,2}. {1}", i, names[i]);




        }
    }
}
