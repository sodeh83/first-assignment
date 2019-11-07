using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[]{1, 1, 5, 2, 3, 4, 4, 5, 6 };
            Array.Sort(array1);
            int[] array2 = new int[array1.Length];
            int j = 0;
            for(int i=0; i<array1.Length-1; i++)
            {
                if(array1[i]!=array1[i+1])
                {
                    array2[j] = array1[i];
                    j++;
                }else
                {
                    i++;
                }
                
            }
          
            array2[j] = array1[array1.Length - 1];
            
            Console.Write("The unique elements in the array is:");
            for(int k=0;k<=j;k++)
            {
                Console.Write(array2[k] + " ");
            }

            Console.ReadKey();
        }
    }
}
