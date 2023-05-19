using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Лямбда - выражения представляют упрощенную запись анонимных методов. Лямбда-выражения позволяют созда
//емкие лаконичные методы, которые могут возвращать некоторое значение и которые можно передать в качестве 
//параметров в другие методы.

//Ламбда-выражения имеют следующий синтаксис: слева от лямбда-оператора => определяется список параметров, 
//а справа блок выражений, использующий эти параметры:

namespace Lyambda_functions
{

    delegate void myDelagate(object obj);
    internal class Program
    {

        static void test(object obj)
        {
            Console.WriteLine("--- {0}",obj);
        }
        static void Main(string[] args)
        {
            int[] _arr = new int[2] { 1, 2 };
            int[] _arr01 = { 1, 2, 6, 7 };

            
            myDelagate Print = (object obj) => {//лямбду функцию складываем в делегат
                Console.WriteLine(obj);
            };
            Print(23);
            Print += (object i) => {
            if(int.Parse(i.ToString()) % 2 == 0)
                {
                    Console.WriteLine($"{i} - четное");    
                }
                    };

            Print += test;
            Print(23); //вызвали делегат
            Print(23);
            foreach (var item in Print.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }
            
            

            
           
            Console.ReadLine();
        }
    }
}
