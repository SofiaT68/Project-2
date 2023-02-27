using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //int[] mass1 = new int[5];
            //for(int i=0; i<mass1.Length; i++)
            //{
            //    Console.Write("Введите число : ");
            //    mass1[i] =Convert.ToInt32 (Console.ReadLine());
            //}
            //foreach (var item in mass1)
            //{
            //    Console.WriteLine(item);
            //}
            //Задание 2
            // int[] mass2 = new int[] { 5, 7, 8, 9, 12 };
            //foreach ( var item in mass2) 
            // {
            //       Console.WriteLine(item);   
            // }
            //Задание3
            //int[] mass3 = new int[7];
            //for(int i =0; i <mass3.Length;i++)
            //{
            //    mass3[i] = i;
            //}
            //foreach(var item in mass3)
            //{
            //    Console.WriteLine(item);
            //}
            //Задание4
            int[] mass4 = new int[5];
            Random r = new Random();
            for(int i=0; i<mass4.Length; i++)
            {
                mass4[i] = r.Next(-100,100);
            }
            foreach(var item in mass4)
            {
                Console.WriteLine(item);
            }
        }
    }
}
