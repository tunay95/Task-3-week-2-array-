using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_week_2___array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task 1

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 25 };
            int b;
            for (int i = 0; i <= 25; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i * i == arr[j])
                    {
                        Console.WriteLine(i * i);



                    }

                }

            }



            // Task 2

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 25 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 1)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);


            // Task 3

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 25 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);


            // Task 4

            //            string words = Console.ReadLine();
            //            int length = words.Length;
            //            bool my_words = true;
            //            for (int i = 0; i < words.Length / 2; i++)
            //            {
            //                if (words[i] != words[length - i - 1])
            //                {
            //                    my_words = true;
            //                    break;
            //                }
            //            }
            //            if (my_words)
            //            {
            //                Console.WriteLine("this word is polindrome");
            //            }
            //            else
            //            {
            //                Console.WriteLine("this word is not polindrome");
        }
    }
}
}
