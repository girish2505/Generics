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
            int[] intArray = { 101, 55, 77, 23, 67, 51 };
            float[] floatArray = { 10.1f, 5.5f, 7.7f, 2.3f, 6.7f, 5.1f };
            string[] stringArray = { "Cat", "Bat", "Rat", "Fat" };

            MaxOfThreeNumbers<int> findForInt = new MaxOfThreeNumbers<int>(intArray);
            MaxOfThreeNumbers<float> findForFloat = new MaxOfThreeNumbers<float>(floatArray);
            MaxOfThreeNumbers<string> findForString = new MaxOfThreeNumbers<string>(stringArray);

            Console.WriteLine("Maximum Integer Number : " + findForInt.MaxValue());
            Console.WriteLine("Maximum Float Number : " + findForFloat.MaxValue());
            Console.WriteLine("Maximum String : " + findForString.MaxValue());
            Console.Read();
        }
    }
}
