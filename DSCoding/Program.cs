using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Selection Sort demo
            int[] arr = new int[] { 1, 0, 9, 5, 3, 2 };
            sortArray(arr);
        }
        public static void sortArray( int[] arr)
        {
            Console.WriteLine("Unsorted array is");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
            int temp=0;
            for ( int i=0; i< arr.Length; i++)
            {
                for ( int j =i; j< arr.Length; j++)
                {
                    if ( arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(" Sorted array is ");
            for ( int k =0; k< arr.Length; k ++)
            {
                Console.WriteLine(arr[k]);
            }
            Console.ReadLine();
        }
    }
}
