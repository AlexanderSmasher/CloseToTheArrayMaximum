using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CloseToTheArrayMaximum
{
    class CloseToTheArrayMaximum
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var inputNums = inputLine.Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            List<object> reals = new List<object>();
            double epsilon = inputNums[0];

            for (int i = 0; i < inputNums.Length; i++)
            {
                if(inputNums[i] == -1)
                {
                    break;
                }
                else if (inputNums[i] == Math.Round(inputNums[i], 0))
                {
                    reals.Add((int)inputNums[i]);
                }
                else
                {
                    reals.Add(inputNums[i]);
                }
            }
            var maxNum = double.MinValue;
            foreach (var key in reals)
            {
                if ((Convert.ToDouble(key) > maxNum) && (Convert.ToDouble(key) != inputNums[0]))
                {
                    maxNum = Convert.ToDouble(key);
                }
            }
            int countMax = 0;
            for (int i = 0; i < reals.Count; i++)
            {
                var tempNum = Convert.ToDouble(reals[i]);
                if ((Math.Abs(tempNum - maxNum) < epsilon))
                {
                    countMax++;
                }
            }
            Console.Write(countMax);
        }
    }
}