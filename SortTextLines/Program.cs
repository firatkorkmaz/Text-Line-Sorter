/* A Program to Sort Text Lines of An Input File and Save Them in A New Textfile */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SortTextLines
{
    class Program
    {
        static void Main(string[] args)
        {
        //Console.WriteLine(Directory.GetCurrentDirectory());
        //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

        FileCheck:
            Console.Write("\nFilename: ");

            //var filename = (string?)null;
            string filename = Console.ReadLine();

            if (filename == null)
            {
                Console.WriteLine("Null Input Detected!");
                goto FileCheck;
            }


            List<string> list;

            try
            {
                list = new List<string>(File.ReadAllLines(filename));
            }
            catch
            {
                Console.WriteLine("No Such File Exists!");
                goto FileCheck;
            }


            int k = filename.LastIndexOf('.');
            string[] savename = { filename.Substring(0, k), filename.Substring(k) };

        Duplicates:
            Console.Write("\nRemove Duplicate Lines? (Y/N): ");
            char duplicate = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (!(duplicate == 'Y' || duplicate == 'y' || duplicate == 'N' || duplicate == 'n'))
            {
                Console.WriteLine("Please Enter Y(Yes) or N(No)");
                goto Duplicates;
            }

        OrderCheck:
            Console.Write("\nOrder the Lines? (Y/N): ");
            char order = Console.ReadKey().KeyChar;
            char asdes = '\0';
            Console.WriteLine();
            if (!(order == 'Y' || order == 'y' || order == 'N' || order == 'n'))
            {
                Console.WriteLine("Please Enter Y(Yes) or N(No)");
                goto OrderCheck;
            }

            if (order == 'Y' || (order == 'y'))
            {
            OrderType:
                Console.Write("\nOrder by Ascending/Descending? (A/D): ");
                asdes = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (!(asdes == 'A' || asdes == 'a' || asdes == 'D' || asdes == 'd'))
                {
                    Console.WriteLine("Please Enter A(Asdencing) or D(Descending)");
                    goto OrderType;
                }
            }

        Trimming:
            Console.Write("\nTrim Lines? (Y/N): ");
            char trimming = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (!(trimming == 'Y' || trimming == 'y' || trimming == 'N' || trimming == 'n'))
            {
                Console.WriteLine("Please Enter Y(Yes) or N(No)");
                goto Trimming;
            }
			
            ///////////////////////////////////////////////////////////////////////
			
			if (trimming == 'Y' || trimming == 'y')
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = list[i].Trim(' ', '\t', '\"', '\'', ',', '.', ';', ':', '=', '-', '_', '*', '~', '|', '(', ')', '[', ']', '{', '}', '+', '%', '&', '^');
                }
            }
			
            if (duplicate == 'Y' || duplicate == 'y')
            {
                list = list.Distinct().ToList();
            }

            if (order == 'Y' || order == 'y')
            {
                if (asdes == 'a' || asdes == 'A')
                {
                    list = list.OrderBy(x => x).ToList();

                }
                else if (asdes == 'd' || asdes == 'D')
                {

                    list = list.OrderByDescending(x => x).ToList();
                }

            }


            Console.WriteLine("\n=================\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            File.WriteAllLines($"{savename[0]}_list{savename[1]}", list);
            Console.WriteLine("\n\n-----------------");
			Console.WriteLine($"New List is Saved in: {savename[0]}_list{savename[1]}");
			

            Console.WriteLine();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            return;
        }
    }
}
