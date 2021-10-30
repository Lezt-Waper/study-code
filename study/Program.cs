using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int>{ 1, 1};
             
            int position = 20 ;

            while (fibonacciNumbers.Count <= position )
            {
                int temp1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
                int temp2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(temp1 + temp2);
            }

            foreach (int i in fibonacciNumbers)
            {
                Console.Write($"{i} \n");
            }
            
        }
        


    }

    
   
}
