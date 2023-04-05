using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class NumCount
    {
        private int num;
        private int noofdigits;


        public NumCount(int num)
        {
            this.num = num;

        }

        public int getdigits(int num, int noofdigits)
        {
            if (num == 0)
                return noofdigits;

            return getdigits(num / 10, ++noofdigits);
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            //int z = 0;
            //do
            //{

            //    //NumCount n = new NumCount(1457777);
            //    //Console.WriteLine(   n.getdigits(1457777, 0));

            //    //2
            //    //bool isprime = true;
            //    //Console.WriteLine("Prime nos");
            //    //for (int i = 300; i <= 400; i++)
            //    //{
            //    //    for (int j = 300; j <= 400; j++)
            //    //    {
            //    //        if (i != j && i % j == 0)
            //    //        {
            //    //            isprime = false;
            //    //            break;
            //    //        }

            //    //    }
            //    //    if (isprime)
            //    //    {
            //    //        Console.WriteLine(" \t" + i);
            //    //    }
            //    //    isprime = true;

            //    //}
            //    //Console.ReadKey();


            //    //3 1 11 111 111 


            //    //for(int i =0;i<=5;i++)  //l
            //    //{
            //    //    for(int j =0;j<=i;j++)
            //    //    {
            //    //        Console.Write("1");
            //    //    }
            //    //    Console.Write(" ");
            //    //}


            //    //write a program that takes a number as input from user.
            //    //The key number is 4 and the user enters single digit numbers.
            //    //Ask the user for a number till he gets the correct answer.
            //    //Then display the number of tries it took to guess the correct number
            //    Console.WriteLine("enter a single digit number:-");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    int guess = 4;

            //        if (input > guess)
            //        {

            //            Console.WriteLine("Try again larger number ");


            //        }
            //        else if (input < guess)
            //        {

            //            Console.WriteLine("try again smaller number");

            //        }
            //        else
            //        {

            //            Console.WriteLine("Correct guess  " );

            //        }

            //        Console.WriteLine("Select 1 for continue and 0 for exit");
            //        z = Convert.ToInt32(Console.ReadLine());
            //    } while (z == 1) ;

            /*  Append one array to another array.
               If array1 is { 5, 6, 7, 8 } and array 2 is { 9, 10, 11, 12 } resultant array will be { 5,6,7,8,9,10,11,12}*/

            int[] arr1 = { 5, 6, 7, 8 };
            //int[] arr2 = { 9, 10, 11, 12 };

            arr1 = arr1.Append(9).ToArray();
            arr1 = arr1.Append(10).ToArray();
            arr1 = arr1.Append(11).ToArray();
            arr1 = arr1.Append(12).ToArray();
            //Concatenate

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

        }

    } //while (z == 1) ;
    }

    
      //  while (z == 1) ;