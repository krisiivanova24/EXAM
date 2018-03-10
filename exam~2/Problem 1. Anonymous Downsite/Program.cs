using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 1;
            int num = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            List<string> sites = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                string siteInf = Console.ReadLine();
                sites.Add(siteInf);
                time = time * key;
               // Console.WriteLine(time);
            }
            List<string> res = new List<string>();
            List<string> split = new List<string>();
            decimal siteLoss = 0;
            //List<string> bigSplit = new List<string>();
            for (int i = 0; i < sites.Count; i++)
            {
                split = sites[i].Split(' ').ToList();
                //Console.WriteLine(string.Join(" . ", split));
                //Console.WriteLine(split[0]);
                string name = split[0];
                res.Add(name);
                int siteVisits = int.Parse(split[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(split[2]);
                siteLoss += siteVisits * siteCommercialPricePerVisit;
                if (i == num - 1)
                {
                    res.Add(siteLoss.ToString());
                }
            }
            for (int i = 0; i < res.Count-1; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine("Total Loss: {0:f20}",res[res.Count-1]);
            Console.WriteLine($"Security Token: {time}");
        }
    }
}
