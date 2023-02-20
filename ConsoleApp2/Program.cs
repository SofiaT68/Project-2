using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            //int[] arr = new int[5] {5,6,4,8,99};
            //int max = 0, ind = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]>max)
            //    {
            //        max = arr[i];
            //        ind = i;
            //    }
            //}
            //Console.WriteLine($"arr[{ind}] = {max}");
            //Задание 2 
            //int[] arr = new int[6] { 7, 8, 3, 45, 67, 3 };
            //int max = 0  , min = 97667 , indMax=0, indMin = 0 , a;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max) 
            //    {
            //        max = arr[i];
            //        indMax = i;

            //    }
            //    if (arr[i]<min)
            //    {
            //        indMin = i;
            //        min = arr[i];
            //    }
            //}
            //a = arr[indMin];
            //arr[indMin] = arr[indMax];
            //arr[indMax] = a;
            //Console.WriteLine($"arr[{indMax}] = {arr[indMax]}");
            //Console.WriteLine($"arr[{indMin}] = {arr[indMin]}");

            //Задание3
            //int[] arr = new int[] { -12, 3, 45, 12, 67, 0, 1 };
            //int  indMax = 0, indMin = 0 ;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > arr[indMax])
            //    {
            //        indMax = i;
            //    }

            //    if (arr[i] < arr[indMin]) 
            //    {
            //        indMin = i;
            //    }
            //}
            //int count = 0;
            //for (int i = indMin+1; i < indMax; i++)
            //{
            //    count++;
            //}
            //Console.WriteLine(count); 

            //Задание4
            //int[] arr = new int[] { -12, 3, 45, 12, 67, 0, 1 };
            //int max = 0, min = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //int absol = max + min;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += Math.Abs(absol);
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);         
            //}

        }
    }
}
