using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

namespace baitap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baitap01();
            //baitap02();
            //baitap03();
            //baitap04();
            //baitap05();
            //baitap06();
            //baitap07();
            //baitap08();
            //baitap09();
            baitap10();
        }
        static void baitap01()
        {
            Console.WriteLine("Input the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number was given is even");
            }
            else
            {
                Console.WriteLine("The number was given is odd");
            }
        }
        static void baitap02()
        {
            Console.WriteLine("Input three number in turn");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());
            if ((a > b) && (b > c))
            {
                Console.WriteLine($"{a} is the largest of three number");
            }
            else if ((b > a) && (a > c))
            {
                Console.WriteLine($"{b} is the largest of three number");
            }
            else
            {
                Console.WriteLine($"{c} is the largest of the number");
            }
        }
        static void baitap03()
        {
            Console.WriteLine("Input a condinate point in turn x,y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if ((x > 0) && (y < 0))
            {
                Console.WriteLine("1st Quadrant");
            }
            else if
                ((x < 0) && (y > 0))
            {
                Console.WriteLine("2st Quadrant");
            }
            else if ((x > 0) && (y > 0))
            {
                Console.WriteLine("1st Quadrant");
            }
            else
            {
                Console.WriteLine("3st Quandrant");
            }
        }
        static void baitap04()
        {
            Console.WriteLine("enter the length of the first side of the triangle side");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the length of the second side of the triangle side");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the length of the third side of the triangle side");
            float c = Convert.ToSingle(Console.ReadLine());
            if ((a == b) || (b == c) || (c == a))
            {
                Console.WriteLine("The given triangle is Isosceles");
            }
            else if ((a == b) && (b == c))
            {
                Console.WriteLine("The given triangle is Equilateral");
            }
            else
            {
                Console.WriteLine("The given triangle is Scale");
            }
        }
        //static void baitap05()
        //{
        //    Console.WriteLine("Enter 10 numbers in turn");
        //    float a = Convert.ToSingle(Console.ReadLine());
        //    float b = Convert.ToSingle(Console.ReadLine());
        //    float c = Convert.ToSingle(Console.ReadLine());
        //    float d = Convert.ToSingle(Console.ReadLine());
        //    float e = Convert.ToSingle(Console.ReadLine());
        //    float f = Convert.ToSingle(Console.ReadLine());
        //    float g = Convert.ToSingle(Console.ReadLine());
        //    float h = Convert.ToSingle(Console.ReadLine());
        //    float i = Convert.ToSingle(Console.ReadLine());
        //    float k = Convert.ToSingle(Console.ReadLine());
        //    float average = (a + b + c + d + e + f + g + h + i + k) * 0.1f;
        //    float sum = a + b + c + d + e + f + g + h + i + k;
        //    Console.WriteLine($"The average of 10 numbers is {average} AND sum of 10 number is {sum}");
        static void baitap05()
        {
            Console.WriteLine("Enter 10 numbers in turn");
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter the number {i}");
                int a = Convert.ToInt32(Console.ReadLine());
                s = s + a;
            }
            Console.WriteLine("The sum of 10 numbers is" + s);
            Console.WriteLine("The avg of 10 numbers is" + s * 0.1);



        }
        static void baitap06()
        {
            Console.WriteLine("Enter the integer number to display the multiplication table");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The multiplication table of the number {a} is");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} ={2}", a, i, a * i);

            }
        }
        static void baitap07()
        {
            /* Write a program to display a pattern like triangles with a number*/
            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void baitap08()
        {
            //            Write a program to display the n terms of harmonic series and their
            //sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            Console.WriteLine("Enter the number of n");
            int n = int.Parse(Console.ReadLine());
            float s = 0;
            Console.WriteLine($"The sum of the first {n} terms of the harmonic series is");
            for (int i = 1; i <= n; i++)
            {
                float term = 1.0f / i;
                Console.Write($"1/{i}" + "+");
                s = (s + term);
            }
            Console.Write("=" + s);
        }
        static void baitap09()
        {
            Console.WriteLine("Enter the starting number of the range:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending number of the range:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect numbers in the given range are:");
            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);

                }
            }
        }
        static void baitap10()
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                    if (sum == a)
                    { Console.WriteLine($"{a} is prime number"); }
                    else 
                    {
                        Console.WriteLine($"{a} is not a prime number");
                    }
                }
            }
        }
    }
}

