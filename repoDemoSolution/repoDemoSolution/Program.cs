using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repoDemoSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my computer is talking wtf");
            Console.Read();
        }

        /// <summary>
        /// 
        /// takes an int as an argument, returns that int times two
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int double_x(int x)
        {
            return x * 2;
        }

        /// <summary>
        /// this method is exclusive to the test branch
        /// </summary>
        static void exclusive()
        {
            return;
        }
    }
}
