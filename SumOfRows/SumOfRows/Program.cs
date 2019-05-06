using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[3, 4];
            
            
            int[] sum = new int[3];
            Console.WriteLine("Enter the elements of the table: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0, -8}", mat1[i, j]);
                    sum[i] += mat1[i, j];
                }
                Console.WriteLine();
            }   

            

            for (int j= 0; j < 3; j++)
            {
                Console.Write("{0, -8}", sum[j]);
            }
            
            Console.ReadKey();
        }
    }



}
 