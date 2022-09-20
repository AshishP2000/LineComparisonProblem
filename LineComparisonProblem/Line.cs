using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Line
    {   
        public static void EnterValue()
        {
            //Take Values from User
            Console.WriteLine("Enter Values for a Line");
            //Decalre Variables
            int x1, y1, x2, y2, x3, y3, x4, y4;
            double Length1, Length2;
            //Line 1
            Console.WriteLine("X1: ");
            //take Values from User
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());


            //Line 2
            Console.WriteLine("X3: ");
            //take Values from User
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y3: ");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X4: ");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y4: ");
            y4 = Convert.ToInt32(Console.ReadLine());

            
            //Formula to find length of line 
            Length1 = Math.Sqrt((x2 - x1 ^ 2 + y2 - y1 ^ 2));
            Length2 = Math.Sqrt((x4 - x3 ^ 2 + y4 - y3 ^ 2));

            //Checking if two lines are eqaul or not 
            if (Length1 == Length2)
            {
                Console.WriteLine("Two Lines are Eqaul");
            }
            else if (Length1 > Length2)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else if (Length2 > Length1)
            {
                Console.WriteLine("Line 2 is greater than Line 1");
            }
            else if (Length1 != Length2)
            {
                Console.WriteLine("Two Lines are not Eqaul");
            }
        }
    }
}
