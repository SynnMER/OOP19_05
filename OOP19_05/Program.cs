using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP19_05
{
    public static class StringExtension
    {
        public static int CharCount(this string str,char c){
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
        public static char Cezar(this char ch)            ////////////////////////////
        {
            ch =(char)(ch + 3) ;               //////////////////////
            return ch;                 ///////////////////////
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = (int)'A'; i <= (int)'Z'; i++)
            //{
            //    if(i > (int)'Z')
            //    {

            //    }
            //    Console.Write($"{(char)i} код {i} " + 
            //       // $"{(char)(i + 32)} код {i+32}"+
            //        $"{(char)(i+3)} код {i+3}\n");
            //}
            Console.WriteLine("* * * * * * * *");
            string text = "Добрый день!",text02="";
            Console.WriteLine(text.GetType());
            Console.WriteLine(text[0].GetType());
            char symb = 'о';
            Console.WriteLine($"B '{text}'"+$"символ '{symb}'"+$" встерчается {text.CharCount(symb)} раз");
            Console.WriteLine("* * * * * * * *");
            for (int i = 0; i < text.Length; i++)
            {
                
                char tmp = text[i].Cezar();                  //////////////////////////
                text02 += tmp;

            }
            Console.WriteLine( $"{text} = {text02}");
            Console.ReadKey();
        }
    }
}
