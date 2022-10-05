using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shahvalad Ayvazov
            #region Task 1
            //1.User gives 2 numbers a, b. Output a to the power of b(not using Math.pow).
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for(int i = 0; i<b; i++)
            //{
            //    result = result * a;
            //}
            //Console.WriteLine(result);
            #endregion
            #region Task 2
            //2.User gives 1 number a. Output amount of number from 1 to 1000 that have no reminder when divided by a.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for(int i = 1; i<1000; i++)
            //{
            //    if(i%a==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region Task 3
            //3.User gives 1 number a. Output all positive numbers whose square will be lesser than a
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    if(Math.Pow(i,2) < a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task 4
            //4.User gives 1 number a. Output largest divisor to that number.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //for (int i = 1; i < a; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        result = i;
            //    }
            //}
            //Console.WriteLine(result);
            #endregion
            #region Task 5
            //5.User gives 2 numbers a,b. Output sum of all numbers from range a to b that have no reminder when divided by 7. (there can be situation when b lesser than a)
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //if(b>a)
            //{
            //    for (int i = a; i <= b; i++)
            //    {
            //        if(i%7==0)
            //        {
            //            sum = sum + i;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = b; i <=  a; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum = sum + i;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task 6
            //6.User gives 1 number a. Output a-th number of Fibonacci’s series. (In Fibonacci series every next number is sum of previous two. F.e. : 1 1 2 3 5 8 13 21 …)
            //int n1 = 0, n2 = 1, n3, n;
            //Console.WriteLine("Enter the number of elements: ");
            //n = Convert.ToInt32(Console.ReadLine()); 
            //for (int i = 2; i < n; i++)
            //{
            //    n3 = n1 + n2;
            //    n1 = n2;
            //    n2 = n3;
            //    #endregion
            //}
            //Console.WriteLine(n2);
            #endregion
            #region Task 7
            //7.User gives 2 numbers.Find out their greatest common divisor using Euclid’s algorithm.
            //int a = Convert.ToInt32(Console.ReadLine()); 
            //int b = Convert.ToInt32(Console.ReadLine());
            //int r = 0;
            //if(a>b)
            //{
            //    r = a % b;
            //    while(r>0)
            //    {
            //        a = b;
            //        b = r;
            //        r = a % b;
            //    }
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    r = b % a;
            //    while (r > 0)
            //    {
            //        b = a;
            //        a = r;
            //        r = b % a;
            //    }
            //    Console.WriteLine(a);
            //}

            #endregion
            #region Task 8 ?
            //8.User gives a positive number that is power of another number to 3. Find out that number using half division method. (F.e. : 8->2 )
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            while(b*b*b != a)
            {                
                if(b*b*b>a)
                {
                    b = b / 2;
                }
                else
                {
                    b = (b * 3)/2;
                }
            }
            Console.WriteLine(b);
            #endregion
            #region Task 9
            //9.User gives 1 number. Find out amount of odd digits in this number.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while(a>0)
            //{
            //    if((a%10)%2==1)
            //    {
            //        count++;
            //    }
            //    a = a / 10;
            //}
            //Console.WriteLine(count);
            #endregion
            #region Task 10
            //10.User gives 1 number. Find out mirrored number to that one. F.e. : 1234 -> 4321
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = 0;
            //int c = 0;
            //while(a>0)
            //{
            //    c = a % 10;
            //    b = c + b * 10;
            //    a = a / 10;
            //}
            //Console.WriteLine(b);
            #endregion
            #region Task 11
            //11.User gives 1 number a. Find out every number in range 1 to a whose sum of even digits bigger than odd.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int sumOfOdds = 0;
            //int sumOfEvens = 0;
            //for (int i = 1; i < a; i++)
            //{
            //    int r = i;
            //    while(r>0)
            //    {
            //        if((r%10)%2==1)
            //        {
            //            sumOfOdds = sumOfOdds + r%10; 
            //        }
            //        else
            //        {
            //            sumOfEvens = sumOfEvens + r%10;
            //        }
            //        r = r / 10;
            //    }
            //    if(sumOfEvens > sumOfOdds)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    r = 0;
            //    sumOfOdds = 0;
            //    sumOfEvens = 0;
            //}
            #endregion
            #region Task 12
            //12.User gives 2 numbers. Find out if there are similar digits in those numbers.
            // 111 -- 1122 YES
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int zapasb = b;
            //int count = 0;
            //while (a > 0)
            //{
            //    int r = a % 10;
            //    while (b > 0)
            //    {
            //        int t = b % 10;
            //        if (t == r)
            //        {
            //            count++;
            //        }
            //        b = b / 10;
            //    }
            //    b = zapasb;
            //    a /= 10;
            //}
            //if (count > 0)
            //{
            //    Console.WriteLine("There are similar digits!");
            //}
            //else
            //{
            //    Console.WriteLine("There are no similar digits!!");
            //}
            #endregion
            #region Task 13
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + (1 + (1 / Math.Pow(i, 2)));
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task 14
            //14.User gives х, and positive n. Calculate:
            //14.1 ?
            //int n = Convert.ToInt32(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());

            //double sum = 1 / x;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        sum = sum + (1 / (x * (x + i)));
            //    }
            //}
            //Console.WriteLine(sum);

            //14.2
            //int n = Convert.ToInt32(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + Math.Pow(x, i) / factorial(i);
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task 15
            //15.User gives positive n. Calculate:
            //15.1
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + (2 + (1 / factorial(i)));
            //}
            //Console.WriteLine(sum);

            //15.2
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + ((1 + i) / factorial(i));
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task 16
            #endregion
            #region Task 17
            //for (int i = 10; i <= 99; i++)
            //{
            //    int count = 0;
            //    int newCount = 0;
            //    for (int j = 2; j <= 9; j++)
            //    {
            //        if (SumOfDigits(i) == SumOfDigits(i * j))
            //        {
            //            Console.WriteLine($"{j} : {i}");

            //        }
            //    }

            //}

            //static int SumOfDigits(int n)
            //{
            //    int sum = 0;
            //    while (n > 0)
            //    {
            //        sum = sum + n % 10;
            //        n = n / 10;
            //    }
            //    return sum;
            //}
            #endregion
            #region Task 18
            //for (int i = 100; i <= 999; i++) /// 154
            //{
            //    int a = i / 100;
            //    int b = (i / 10) % 10;
            //    int c = i % 10;
            //    if (factorial(a) + factorial(b) + factorial(c) == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //static int factorial(int n)
            //{
            //    int result = 1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        result = result * i;
            //    }
            //    return result;
            //}
            #endregion
            #region Task 19
            //19.Is it possible to represent given number as sum of two positive numbers powered to 2? 
            //void TwoNumbersPoweredSum(int n)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        for (int j = 0; j <= n; j++)
            //        {
            //            if (i * i + j * j == n)
            //            {
            //                Console.WriteLine($"{i}^2 + {j}^2 = {n}");
            //                return;
            //            }
            //        }
            //    }
            //}
            #endregion
            #region Task 20
            //void PerfectNumber(int n)
            //{
            //    int sum = 0;
            //    for (int i = 1; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            sum = sum + i;
            //        }
            //    }
            //    if (sum == n)
            //    {
            //        Console.WriteLine($"{n} - is a perfect number!");
            //        Console.ReadKey();
            //        return;
            //    }
            //    Console.WriteLine($"{n} - is not a perfect number!");
            //    Console.ReadKey();
            //}
            #endregion
            #region Task 21
            #endregion




        }
        static int factorial(int n) // It is for tasks that have factorial in it.
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
        
    }
}
