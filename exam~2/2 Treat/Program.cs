using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Treat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            string com = Console.ReadLine();
            List<string> commands = new List<string>();
            while (com!="3:1")
            {
                commands.Add(com);
                com = Console.ReadLine();
            }
            List<string> otdel = new List<string>();
            List<string> res = new List<string>();
             List<string> newRes = new List<string>();
            for (int i = 0; i < commands.Count; i++)
            {
                otdel = commands[i].Split(' ').ToList();
                string command = otdel[0];
                byte index1 = byte.Parse(otdel[1]);
                byte index2 = byte.Parse(otdel[2]);
                if (String.Equals(command, "merge"))
                {
                    if (input.Count == 0)
                    {
                        input.Add(string.Join("", res));
                        break;
                    }
                    if (index2> input.Count)
                    {
                        index2 = (byte)(input.Count-1);
                    }
                    if (index1> input.Count)
                    {
                        index1 = 0;
                    }
                    for (int z = index1; z <= index2; z++)
                    {
                        res.Add(input[z]);
                        //res.Add("");
                        
                    }
                    for (int t = index1; t <= index2; t++)
                    {
                        input.RemoveAt(index1);
                    }
                    //Console.WriteLine(string.Join(" > ", input));
                    
                }
                      
                else
                {
                    input.Add(string.Join("",res));
                    
                   // Console.WriteLine(string.Join(" ", input));
                    char[] characters = input[index1].ToCharArray();
                    int chislo = characters.Length /index2;
                   //Console.WriteLine(chislo + " ++");
                    //if (chislo == 1)
                    //{
                    //    index2 = 1;
                    //}
                    //else
                    //{
                    //    index2 += 4;
                    //}
                  
                    for (int p = 0; p <= index2+4; p+=2)
                    {
                        string ress = string.Concat(characters[p], characters[p + 1]);
                        newRes.Add(ress);
                       //Console.WriteLine(ress + " ,,, ");
                    }
                    //Console.WriteLine(string.Join(" --- ",characters));
                    input.RemoveAt(input.Count-1);
                    input.AddRange(newRes);
                   
                }
                //Console.WriteLine(res.Count);
                
            }
            Console.WriteLine(string.Join(" ", input));
                
        }
    }
}
