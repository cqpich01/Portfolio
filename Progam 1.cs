//Grading ID: J5305
//Program 1
//Due: 9/22/2019
//CIS199-01
//This program calculates the number of gallons needed to paint walls in a room. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length; //User input for length 
            double height; //User input for height 
            double squareFeet; //user input for squarefeet
            double minGallons; //user input for minimum number of gallons
            uint doors; //User input for number of doors 
            uint windows; //User input for number of windows 
            uint coats; //User input for number of coats of paint

            //Output variables 
            uint actualGallons;

            //Constants created so there are no magic numbers 
            const uint SQUARE_FEET_OF_DOORS = 21; //21 feet subtracted per door 
            const uint SQUARE_FEET_OF_WINDOWS = 12; //12 feet subtracted per window 
            const uint FEET_PER_CAN = 400; //Each can of paint should cover 400 squarefeet 


            //Converting user input 
            Write("Enter the total length of all walls (in feet): ");
            height = double.Parse(ReadLine());

            Write("Enter the height of the walls (in feet): ");
            length = double.Parse(ReadLine());

            Write("Enter the number of doors (non-neg int): ");
            doors = uint.Parse(ReadLine());

            Write("Enter the number of windows (non-neg it): ");
            windows = uint.Parse(ReadLine());

            Write("Enter the number of coats (non-neg it ): ");
            coats = uint.Parse(ReadLine());

            
            squareFeet = length * height; //formula to calculate sqaure feet of room 
            squareFeet = squareFeet - (SQUARE_FEET_OF_DOORS * doors); //formula to calculate squarefeet of room without doors 
            squareFeet = squareFeet - (SQUARE_FEET_OF_WINDOWS * windows); //fromula to calculate squarefeet of room without windows or doors 
            squareFeet = squareFeet * coats; //formula to caclulate squarefeet times the number of coats 

            //Calculation to find total square feet that requires painta
            minGallons = squareFeet / FEET_PER_CAN; //Minimum number of gallons
            actualGallons = (uint)Math.Ceiling(minGallons); //Number of Gallons to buy 

            WriteLine($"You need a minimum of {minGallons:F1} gallons of paint. You'll need to buy {actualGallons} gallons, though."); //WriteLine to display minimun number of gallons and actual number of gallons needed to buy











            






        }
    }
}

