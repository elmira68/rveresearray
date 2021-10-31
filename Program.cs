using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void rversearray(int []arr , int start , int end)
        {
            int temp;
            if (start >= end)
            return;

            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            rversearray(arr , start+1 , end-1);
        }
        static void printarray(int []arr , int size)
        {
            for (int i = 0; i < size; i++)
            
               Console.Write(arr[i] + "");
               Console.WriteLine(""); 
            
        }
    
       
       
        public static void Main()
        {
          int []arr = {5,2,3,6,9,8};

          printarray(arr , 6);
          rversearray(arr , 0 , 5);
          
          Console.WriteLine("reversed array is");
          printarray(arr , 6);
        }

    }
}