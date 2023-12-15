using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecutive_Script
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int tempBuffer = 0;
            bool isConsecutive = true;
            Console.WriteLine("Please input numbers with '-' ");
            string InputString = Console.ReadLine();

            string[] splitString = InputString.Split('-');
            for (int i = 0; i < splitString.Length; i++)
            {   
                int temp = int.Parse(splitString[i]);
                numbers.Add(temp);
            }

            for (int i = 0; i < numbers.Count -1; i++)
            {
                if ((numbers[i] + 1 != numbers[i + 1]) && (numbers[i] - 1 != numbers[i + 1]))
                {
                    isConsecutive = false;
                    break;
                }
            }

            

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
            
        }
    }
}
