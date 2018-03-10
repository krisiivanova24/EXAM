using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> all = new List<string>();
            while (input != "I believe I can fly!")
            {
                all.Add(input);
                input = Console.ReadLine();
            }
            all.Sort();
            Dictionary<string, List<int>> sorted = new Dictionary<string, List<int>>();
            for (int i = 0; i < all.Count; i++)
            {
                List<int> names = new List<int>();
                List<string> otdelno = all[i].Split(' ').ToList();
                Console.WriteLine(string.Join(" , ", otdelno));
                string ime = otdelno[0];
                for (int w = 1 ; w < otdelno.Count; w++)
                {
                    names.Add(int.Parse(otdelno[w]));
                }
                names.Sort();
                sorted[ime] = names;

            }
            foreach (var pair in sorted)
            {
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value)}");
            }
        }
    }
}
