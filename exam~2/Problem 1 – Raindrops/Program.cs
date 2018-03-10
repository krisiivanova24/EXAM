using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float density = float.Parse(Console.ReadLine());
            List<string> nums = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                nums.Add(line);
            }
            List<string> delim = new List<string>();
            float chastno = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                delim = nums[i].Split(' ').ToList();
               // Console.WriteLine(string.Join(" > ", delim));
                chastno += float.Parse(delim[0]) / float.Parse(delim[1]);
                
            }
            //Console.WriteLine(chastno);
            chastno = chastno / density;
            Console.WriteLine($"{chastno:f3}");
        }
    }
}
