using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.CodeDom;

namespace LL_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //John Jenson tacal
            //IT402P

            //LinkedList Declaration
            LinkedList<string> name = new LinkedList<string>();


        inputVal:
            Console.Clear();
            //Input Total number of nodes
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Youmay input Student first names from 5 to 10");
            Console.Write("How many names would you like to input: ");
            int TotalNames = Convert.ToInt32(Console.ReadLine());
            
            //For Limiting the Total number of names
            if (TotalNames < 5 || TotalNames > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter numbers from 5-10");
                //Using Thread.Sleep for display delay
                Thread.Sleep(1000);
                goto inputVal;
            }

            //For Name Input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEnter 5 names of your classmates");
            Console.ForegroundColor = ConsoleColor.White;
            for(int i = 0; i < TotalNames; i++)
            {
                //using if else looping for a clean display of interface
                if (i == 0)
                {
                    i++;
                    Console.Write($"{i}st Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
                else if (i == 1)
                {
                    i++;
                    Console.Write($"{i}nd Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
                else if (i == 2)
                {
                    i++;
                    Console.Write($"{i}rd Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
                else
                {
                    i++;
                    Console.Write($"{i}th Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
            }

            //Display Name
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("-----Inputed Names-----");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string value in name)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();


        }
    }
}
