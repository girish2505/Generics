using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic programs");
            MaxOfThreeNumbers maxOfThreeNumbers = new MaxOfThreeNumbers();
            maxOfThreeNumbers.MaxOfThree(10,20,30);

        }
    }
}
