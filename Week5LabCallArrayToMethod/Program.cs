using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5LabCallArrayToMethod
{
    /*  Define an array of integers, 7 elements in length. This will store a temperature for each day
        Create a for loop that asks user what the temperature is for each day and save that value into the array
        Pass that array into a method (define then call a method) that does the following:
        Has one parameter, accepting int[]
        Writes "pretty" data to the screen as in the second video, showing a title row, a title separator row, 
        and having each column be 10 characters in width using string interpolation formatting */

    class Program
    {
        private const int numberOfDays = 7; 

        static void Main(string[] args)
        {
            int[] temps = new int[numberOfDays]; //set array length to 7 (or "numberOfDays")

            for (int counter = 0; counter < numberOfDays; counter++) //7 times, get temp for each day.
            {
                Console.WriteLine($"What's the temperature on day {counter + 1}?");
                temps[counter] = int.Parse(Console.ReadLine());
            }

            int total = 0; //initialize total temps for week

            Console.WriteLine("To review, all of this weeks temperatures are:\n");
            foreach (int temp in temps) 
            {
                Console.WriteLine(temp); 
            }

            GlobalWarming(temps);

            Console.WriteLine($"\nIn 25 years, those same daily temperatures will be more like: ");
            foreach (int temp in temps)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
            //you need to write those last bits as one table, looking pretty.
            //you can do it!

        static void GlobalWarming (int[] theseTemps)  //this does what you want it to. good job.
        {
            for (int counter = 0; counter < theseTemps.Length; counter++) 
            {
                theseTemps[counter] = theseTemps[counter] + 10;
            }
        }
    }
}
