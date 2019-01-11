using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Hello " + name + ", today is " + localDate);
            Console.ReadKey();
        }
    }
}
