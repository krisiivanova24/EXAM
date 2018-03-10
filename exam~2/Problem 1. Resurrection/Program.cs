using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            List<int> lengthB = new List<int>();
            List<double> widthB = new List<double>();
            List<int> wings = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int length = int.Parse(Console.ReadLine());
                lengthB.Add(length);
                double width = double.Parse(Console.ReadLine());
                widthB.Add(width);
                int wing1 = int.Parse(Console.ReadLine());
                wings.Add(wing1);
            }
            for (int i = 0; i < num; i++)
            {
                //Console.WriteLine(lengthB[i]);
                //Console.WriteLine(widthB[i]);
                //Console.WriteLine(wings[i]);
                double res = (lengthB[i] * lengthB[i])  * (widthB[i] + 2 * wings[i]);
                Console.WriteLine(res);
            }
            Console.WriteLine();
        }
    }
}
