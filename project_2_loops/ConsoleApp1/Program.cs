using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0;i<100;i++ )
            //{
            //    Console.WriteLine("Bangladesh");
            //}
            //Console.ReadKey();
            //int sum = 0,even=0,odd=0;
            //for(int i = 1; i < 101; i++)
            //{
            //    sum += i;
            //    //if (i % 2 == 0)
            //    //{
            //    //    even += i;
            //    //}
            //    //else
            //    //{
            //    //    odd += i;
            //    //}
            //}
            //Console.WriteLine("Sum of the the whole loop "+sum);
            //for (int i = 1; i <= 100; i+=2)
            //{
            //        odd += i; 
            //}
            //Console.WriteLine("Sum of the the odd " + odd);
            //for (int i = 2; i < 101; i += 2)
            //{
            //    even += i;
            //}
            //Console.WriteLine("Sum of the the even " + even);
            //int i = 0, sum = 0;
            //while(i<=100)
            //{
            //    sum += i;
            //    i++;
            //}
            ////Console.WriteLine("Sum = " + sum);
            //string s = "";
            //string dhaka = "Dhaka";

            ////while(s!=dhaka) {
            ////     Console.WriteLine("enter a city");
            ////    s = Console.ReadLine();
            ////}

            //do
            //{
            //    Console.WriteLine("enter a city");
            //    s = Console.ReadLine();
            //}
            //while (s != dhaka);


            //Console.WriteLine("Enter 5 numbers");
            //int numbers=0,max=0;
            //for (int i=1;i<=5;i++) 
            //{
            //    Console.WriteLine("Enter number "+ i);//4, 322, 3, 2, 1
            //    numbers = Convert.ToInt16(Console.ReadLine());
            //    if (numbers > max)
            //        max = numbers;
            //}
            //Console.WriteLine(max);
            //Console.WriteLine("Enter a number");
            //int n = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Time table of n");

            //for( int i=1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
            //}


            //Array

            string[] city = new string[5] { "Dhaka", "Pabna", "Narail", "Khulna", "Chittagong" };
            //Console.WriteLine(city[1]);
            //string[] ct = new string[] { "Dhaka","Khulna","Chittagong"};
            //string[] c = new string[4];
            //c[0] = "Dhaka";
            //c[1] = "Madaripur";

            //foreach (string c in city)
            //{
            //    Console.WriteLine(c);
            //}

            //for(int i=0;i<city.Length;i++)
            //{
            //    Console.WriteLine(city[i]);
            //}

            int[] num = new int[11] { 10, 5, 11, 20, 40, 21, 29, 21, 9, 12, 23 };
            int[] even = new int[11];
            int[] odd = new int[11];
            int ev = 0, od = 0;
            //int max = 0;
            //for(int i=0; i<num.Length; i++)
            //{
            //    if (num[i] > max)
            //    {
            //        max = num[i];
            //    }
            //}
            //Console.WriteLine("maximum number " + max);

            //task 2: find odd numbers and even numbers from the Array

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even[i] = num[i];
                    ev++;

                }
                else
                {
                    odd[i] = num[i];
                    od++;
                }

            }
            Console.WriteLine("Total even numbers: ");
            foreach (int a in even)
            {
                if (a != 0)
                {
                    Console.WriteLine(even[a]);

                }


            }

            Console.WriteLine("Total even numbers: ");
        }
    }
}
