using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyahov_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task1
            //string str = "Алина Полина Катя Женя Маша Оля";
            //Console.WriteLine(str);
            //string[] names = str.Split(new char[] { ' ' });
            //string no_masha = str.Substring(0, str.IndexOf("Маша")).Replace(" ", "\n");

            //string[] sorted_no_masha = no_masha.Split(new char[] { '\n' });
            //var sorted = sorted_no_masha.OrderBy(x => x);
            //foreach (string n in sorted)
            //{
            //    Console.WriteLine(n);
            //}

            ////task2
            //string str = "fghdrthetdfyreastawtwyert";
            //Console.WriteLine(str);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        str = str.Insert(i, " ");
            //    }
            //}
            //string[] four_elems = str.Split(new char[] { ' ' });
            //Console.WriteLine(str);
            //for (int i = 1; i < four_elems.Length - 1; i++)
            //{
            //    if (four_elems[i].Length == 4)
            //    {
            //        four_elems[i] = four_elems[i].Replace(four_elems[i], "love_Is");
            //    }
            //}
            //foreach (string s in four_elems)
            //{
            //    Console.Write(s);
            //}

            ////task 3
            int n = 3;
            string str = "fghdrthetdfyreastawtwyert";
            char smile = Convert.ToChar(01);
            string res = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % n == 0)
                {
                    res = str.Insert(n, smile.ToString());
                }
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
