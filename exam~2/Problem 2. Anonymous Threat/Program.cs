﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> input2 = input.ToList();
            string command = Console.ReadLine();
            List<string> com = new List<string>();
            while (command != "3:1")
            {
                com.Add(command);
                command = Console.ReadLine();
            }
            List<string> split = new List<string>();
            List<string> res = new List<string>();
            List<string> res2 = new List<string>();
            for (int i = 0; i < com.Count; i++)
            {
                split = com[i].Split(' ').ToList();
                string doing = split[0];
                int index1 = int.Parse(split[1]);
                int index2 = int.Parse(split[2]);

                if (String.Equals(doing, "merge"))
                {
                    for (int e = index1; e < input.Count; e = e +2)
                    {
                        string hhh = input[i].ToString().Concat(input[i + 1].ToString());
                    }
                    //if (String.Equals(string.Join("", res), string.Join("", input2)))
                    //{
                    //    break;
                    //}
                    //if (index2 >= input.Count)
                    //{
                    //    for (int y = 0; y < input.Count; y++)
                    //    {
                    //        //Console.WriteLine(input[y] + "j");
                    //        res.Add(input[y]);
                    //    }
                    //}
                    //else
                    //    for (int y = index1; y <= index2; y++)
                    //    {
                    //        // Console.WriteLine(input[y] + "k");
                    //        res.Add(input[y]);
                    //    }
                    //for (int f = 0; f < res.Count; f++)
                    //{
                    //    if (input.Count == 1)
                    //    {
                    //        input.RemoveAt(0);
                    //        break;
                    //    }
                    //    else
                    //        input.RemoveAt(0);
                    //}
                    ////Console.WriteLine(string.Join(", ", res));


                }
                else ////////////////////////////////////////////////////////////////////////////
                {
                    
                    Console.WriteLine(res.Count);
                   // res = new List<string>();
                    if (index2 >= res.Count)
                    {
                        for (int y = index1; y < res.Count; y++)
                        {
                            res2.Add(input[y]);
                            res.RemoveAt(index1);
                        }
                    }
                    else
                        for (int y = index1; y < index2; )
                        {
                            res.Add(input[y]);
                            res.RemoveAt(index1);
                        }
                    Console.WriteLine(string.Join(" + ",res2));
                    for (int f = 0; f < res2.Count; f++)
                    {

                    }
                    Console.WriteLine(res.Count);
                }
            }
            Console.WriteLine(string.Join("", res));
        }
    }
}
