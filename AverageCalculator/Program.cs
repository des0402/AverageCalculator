using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Calculator\n");
            Console.Write("Enter number of items to be calculated for average: ");
            int numberOfItems = int.Parse(Console.ReadLine());

            double[] numberArray = new double[numberOfItems];
            double sum = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                Console.Write("Enter number {0} : ", i+1);
                numberArray[i] = double.Parse(Console.ReadLine());
                sum += numberArray[i];
            }

            double average = sum / numberOfItems;
            Console.WriteLine("\nAverage is: {0}", average);

            Console.ReadLine();

        }
    }
}
