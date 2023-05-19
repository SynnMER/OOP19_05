﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19_05_23
{
    delegate void myDelegate(object obj);
    internal class Program
    {
        static  void myTest (object obj) 
        {
            Console.WriteLine("{test} - 0",obj);
        }
        static void Main(string[] args)
        {
            int[] _arr = new int[2] { 1, 8 };
            int[] _arr01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myDelegate Print = (object obj) => 
            {
                Console.WriteLine(obj);
            };
            Print += (object i) =>                     //////////////////////////
            {
                if(int.Parse(i.ToString()) % 2 == 0)
                {
                    Console.WriteLine("chet");
                }
                else
                    Console.WriteLine("nechet");
            };
            Print += myTest;  
            Print(24);
            foreach (var item in Print.GetInvocationList())           /////////////////////
            {
                Console.WriteLine(item.Method);
            }
            Print = myTest;

            Print(20);
        }
    }
}
