using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Problem_2___Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listNum2 = listNum.ToList();
            int initial = listNum[listNum.Count - 1];
            listNum.RemoveAt(listNum.Count-1);
            List<int> indexes = new List<int>();
            indexes.Add(initial);
            for (int i = 0; i < listNum.Count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                indexes.Add(num);
            }
            //Console.WriteLine(string.Join(" > ", indexes));
           // Console.WriteLine(initial);
            int step = 0;
            byte times = 0;
            for (int i = 0; i < indexes.Count; i++)
            {
                times = 0;
                int index = indexes[i];
                //Console.WriteLine(index + " k");
                for (int j = index; j < listNum.Count; j++)
                {
                    listNum[j]--;
                    times++;
                }
                if (times< listNum.Count)
                {
                    step++;
                    for (int j = 0; j < index; j++)
                    {
                        listNum[j]--;
                        times++;
                        
                    }
                }
                for (int t = 0; t < listNum.Count; t++)
                {
                    if (listNum[t] == 0)
                    {
                        if (index == t)
                        {
                            break;
                        }
                        else
                        {
                            listNum[t] = listNum2[t];
                        }
                    }
                }
               // Console.WriteLine(string.Join(" ", listNum));
                //Console.WriteLine(step + " p");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", listNum));
            Console.WriteLine(step);
        }
    }
}
