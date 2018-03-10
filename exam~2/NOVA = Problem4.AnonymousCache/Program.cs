using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVA___Problem4.AnonymousCache
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
            int sizes = 0;
            int sizess = 0;
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list11 = new List<string>();
            List<string> list22 = new List<string>();
            list1.Add(dataSets[0]);
            list2.Add(dataSets[1]);

            List<string> split = new List<string>();
            for (int i = 0; i < dataKeys.Count; i++)
            {
                split = dataKeys[i].Split(' ', '-', '>', '|').ToList();
                string key = split[0];
                int size = int.Parse(split[4]);
                // Console.WriteLine(size + " _");
                string set = split[7];

                if (String.Equals(set, dataSets[0]))
                {
                    if (list1.Count >= 2)
                    {
                        list1.RemoveAt(1);
                    }
                    sizes += size;
                 
                    list1.Add(sizes.ToString());
                    list11.Add(key);

                }
                else
                {
                    if (list2.Count >= 2)
                    {
                        list2.RemoveAt(1);
                    }
                    sizess += size;
                    list2.Add(sizess.ToString());
                    list22.Add(key);
                }

            }
            list1.AddRange(list11);
            list2.AddRange(list22);
            //list1.Sort();
            //list2.Sort();
            //Console.WriteLine(string.Join(" ", list1));
            //Console.WriteLine(string.Join(" ", list2));
            if (list1.Count > list2.Count)
            {
                Console.WriteLine($"Data Set: {list1[0]}, Total Size: {list1[1]}");
                for (int i = 0; i < list11.Count; i++)
                {
                    Console.WriteLine($"$.{list11[i]}");
                }
            }
            else
            {
                Console.WriteLine($"Data Set: {list2[0]}, Total Size: {list2[1]}");
                for (int i = 0; i < list22.Count; i++)
                {
                    Console.WriteLine($"$.{list22[i]}");
                }
            }
        }
    }
}
