using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<string> all = new List<string>();
            while (word != "ReadMe")
            {
                all.Add(word);
                word = Console.ReadLine();
            }
            List<string> res = new List<string>();
            for (int i = 0; i < all.Count; i++)
            {
                char[] each = all[i].ToArray();
               
                if (all[i].Contains("_") || all[i].Contains(" "))
                {
                    res.Add("No");
                    continue;
                }
                Array.Reverse(each);
                //Console.WriteLine(string.Join(">>", each));
                if (String.Equals(string.Join("", each), all[i]))
                {
                    res.Add("Yes");
                    continue;
                }
                else
                {
                    res.Add("No");
                }
            }
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

    }
}

