using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        class Result
        {

            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             * 6
               -4 3 -9 0 4 1
             */

            public static void plusMinus(List<int> arr)
            {
                decimal positiveNumbers = 0;
                decimal negativeNumbers = 0;
                decimal zeroNumbers = 0;
                int count = arr.Count;
                foreach (var number in arr)
                {
                    if (number == 0)
                        zeroNumbers++;
                    else if (number > 0)
                        positiveNumbers++;
                    else
                        negativeNumbers++;
                }

                Console.WriteLine(positiveNumbers / count);
                Console.WriteLine(negativeNumbers / count);
                Console.WriteLine(zeroNumbers / count);
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                Result.plusMinus(arr);
            }
        }
    }
}
