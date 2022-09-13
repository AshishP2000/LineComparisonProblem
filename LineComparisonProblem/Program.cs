using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            //UC-1 Calculate Length of Line
            //Take Values from User
            Console.WriteLine("Enter Values for a Line");

            //Decalre Variables
            int x1,y1, x2, y2;
            double Length;

            Console.WriteLine("X1: ");
            //take Values from User
            x1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            y1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            x2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            //Formula to find length of line 
            Length = Math.Sqrt((x2-x1^2+y2-y1^2));

            //Printing Lenght of a line
            Console.WriteLine("Length of a Line is: "+Length);

            Console.ReadLine();
        }
    }
}
