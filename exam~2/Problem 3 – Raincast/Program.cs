using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> type = new List<string>();
            List<string> source = new List<string>();
            List<string> forecast = new List<string>();
          
            List<string> input = Console.ReadLine().Split(':').ToList();
            
            do
            {
               // Console.WriteLine(input[1] + " k ");
                if (!String.Equals(input[1], " Invalid Input Line") && input[1] != " Bau" && input[1] != " Myau" && input[1] != " Strong" && input[1] != " Good" && input[1] != " Valid")
                {
                    if (String.Equals(input[0], "Type"))
                    {
                        type.Add(input[1]);
                    }
                    else
                    {
                        if (String.Equals(input[0], "Source"))
                        {
                            source.Add( input[1]);
                        }
                        else
                        {
                            forecast.Add(input[1]);
                        }
                    }
                }

                input = Console.ReadLine().Split(':').ToList();

            } while (!String.Equals(string.Join(" ", input), "Davai Emo"));
            
            if (type.Count>source.Count)
            {
                type.RemoveAt(type.Count-1);
            }
            //Console.WriteLine(string.Join(" > ", type));
            //Console.WriteLine(string.Join(" >> ", source));
            //Console.WriteLine(string.Join(" >>> ", forecast));
            for (int i = 0; i < type.Count; i++)
            {
                Console.WriteLine($"({type[i]}){forecast[i]} ~{source[i]} ");
            }
       
        }
    }
}
