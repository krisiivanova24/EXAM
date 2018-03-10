using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            List<string> dataSets = new List<string>();
            List<string> dataKeys = new List<string>();
            while (lines != "thetinggoesskrra")
            {
                if (lines.Contains(">"))
                {
                    dataKeys.Add(lines);
                }
                else
                {
                    dataSets.Add(lines);
                }
                lines = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" , ", dataSets));
            Console.WriteLine(string.Join(" = ", dataKeys));
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, List<string>> dic2 = new Dictionary<string, List<string>>();
            List<string> keys = new List<string>();
            List<string> split = new List<string>();
            int times = 0;
            string name = null;
            for (int i = 0; i < dataKeys.Count; i++)
            {

                split = dataKeys[i].Split(' ', '-', '>', '|').ToList();
                Console.WriteLine(string.Join(" > ", split));
                string key = split[0];
                Console.WriteLine(key + "k");
                Console.WriteLine(split[4] + "l");
                int size = int.Parse(split[4]);

                string set = split[7];
                Console.WriteLine(set + "m");
                if (!dic.ContainsKey(set))
                {
                    dic[set] = size;
                }
                else
                {
                    dic[set] += size;
                }
                if (name == null)
                {
                    name = key;
                    keys.Add(key);
                    dic2[set] = keys;
                    times = keys.Count;
                    keys = new List<string>();
                }
                else
                {
                    keys.Add(key);
                    dic2[set] = keys;
                }
            }
            Console.WriteLine(times);
            Console.WriteLine(keys.Count);
            Console.WriteLine(dic2.Count -1 );
            //dic2.OrderByDescending(pair => (pair.Value)).ToDictionary(pair=>pair.Key, pair=> pair.Value );
            if (times < keys.Count)
            {
                for (int i = dic2.Count - 1 ; i > 0; i++)
                {
                    int size = 0;
                    string what = dic2[i].ToString();
                    Console.WriteLine(what);
                    //Console.WriteLine($"Data Set: {}, Total Size: {dic.TryGetValue(dic2.ElementAt(i), out size)}");
                }
            }
            foreach (var pair in dic)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            foreach (var pair in dic2)
            {
                Console.WriteLine($"{pair.Key} {string.Join(" + ", pair.Value)}");
            }
        }
    }
}
