/*
 * Author: Logan Jones
 * Course: COMP003A
 * Purpose: Week 3 Weekly Assingment: If-Else Statements
 */


using System.ComponentModel.Design;

namespace COMP003A.Assingment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter test score here:");
            double numericGrade = Convert.ToDouble(Console.ReadLine());
            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (numericGrade >=80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (numericGrade >= 70)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (numericGrade >= 60)
                {
                    Console.WriteLine(" Letter Grade: D");
                }
                else
                {
                    Console.WriteLine("Letter Grade: F");
                } 
                
            }
          else { Console.WriteLine("Invalid input!"); }
            Console.WriteLine("/**********************************************/");

            Console.WriteLine("Pick a number from 1 through 7! Enter it below!");
            int numericDay = Convert.ToInt32(Console.ReadLine());
            switch (numericDay)
            {
                case 1: Console.WriteLine("It's Monday!");
                    break;
                case 2: Console.WriteLine("It's Tuesday!");
                    break;
                case 3: Console.WriteLine("It's Wednesday!");
                    break;
                case 4: Console.WriteLine("It's Thursday!");
                    break;
                case 5: Console.WriteLine("It's Friday!");
                    break;
                case 6: Console.WriteLine("It's Saturday!");
                    break;
                case 7: Console.WriteLine("It's Sunday!");
                    break;
                default: Console.WriteLine("Invalid day! Try Again!");
                    break;

            }

           
        }
    }
}
