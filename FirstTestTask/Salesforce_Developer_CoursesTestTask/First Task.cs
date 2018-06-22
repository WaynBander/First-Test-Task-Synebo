using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce_Developer_CoursesTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, result;
            string line;
            Console.WriteLine("Enter A:");
            line=Console.ReadLine();
            A = Convert.ToInt32(line);
            while (A < 0)
            {
                Console.WriteLine("You enter A less than 0,change you enter data for A");
                Console.WriteLine("Enter A:");
                line = Console.ReadLine();
                A= Convert.ToInt32(line);
            }
                Console.WriteLine("Enter B that bigger or equels than A:");
            line=Console.ReadLine();
            B = Convert.ToInt32(line);
            while (A>B)
            {
                Console.WriteLine("You enter B less than A,change you enter data for B");
                Console.WriteLine("Enter B:");
                line = Console.ReadLine();
                B = Convert.ToInt32(line);
            }
           result= SquadFind(A, B);
            Console.WriteLine("Result SquadFind:{0}",result);
            Console.ReadLine();

        }
        public static int SquadFind(int a,int b)
        {
            return (int)Math.Sqrt(b)-(int)Math.Sqrt(a-1);
        }
    }
}
