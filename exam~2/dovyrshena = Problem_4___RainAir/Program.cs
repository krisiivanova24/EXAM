using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dovyrshena___Problem_4___RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> all = new List<string>();
            int length = 0;
            while (input != "I believe I can fly!")
            {
                all.Add(input);
                if (input.Contains("="))
                {
                    length = -1;
                }
                input = Console.ReadLine();
            }
            
            all.Sort();
           
            Dictionary<string, List<int>> sorted = new Dictionary<string, List<int>>();
            List<int> names = new List<int>();
            for (int i = 0; i < all.Count + length; i++)
            {

                List<string> otdelno = all[i].Split(' ').ToList();

                string ime = otdelno[0];
                if (otdelno.Contains("="))
                {
                    otdelno.Remove("=");

                    List<int> jjjjj = new List<int>();
                    
                    var ww = sorted.TryGetValue(otdelno[1], out jjjjj);
                  
                    sorted[ime] = jjjjj;
                    continue;
                }
                if (sorted.ContainsKey(ime))
                {
                  
                    names.Add(int.Parse(otdelno[1]));
                    names.Sort();
                                        
                    sorted[ime] = names;
                    names = new List<int>();
                    continue;
                }
                else
                {
                    for (int w = 1; w < otdelno.Count; w++)
                    {
                        names.Add(int.Parse(otdelno[w]));
                    }
                   // Console.WriteLine(string.Join(" > ", names));
                }

                names.Sort();
                sorted[ime] = names;
                if (length == 0)
                {
                    names = new List<int>();
                }


            }
            foreach (var pair in sorted)
            {
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value)}");
            }
        }
    }
}
