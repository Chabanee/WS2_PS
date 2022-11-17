using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS1_PS
{
    class Program
    {
        static void Main(string[] args)
        {
            UpperCase U = new UpperCase();
            U.changeToUpperCase();
            Console.WriteLine("");

            Console.WriteLine("Presse a key to close the cmd line.....");
            Console.ReadKey();
        }
    }
}
