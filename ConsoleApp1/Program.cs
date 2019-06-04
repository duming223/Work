using System;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("取下列数中最大值！");
            //int max = 0;
            //int[] array = { 1, 56, 33, 22, 89, 23, 55, 100, 54, 44, 33, 66 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]};");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] >= max)
            //    {
            //        Console.WriteLine("第{0}次比较{1}>{2},最大值为{3}", i + 1, array[i], max, array[i]);
            //        max = array[i];
            //    }
            //    else
            //    {
            //        Console.WriteLine("第{0}次比较{1}<{2},最大值为{3}", i + 1, array[i], max, max);
            //    }
            //    Console.WriteLine($"最大数是{max}");


            //for (int a = 1; a <= 9; a++)
            //{
            //    for (int b = 1; b <=a; b++)
            //    {
            //        Console.Write("{0}x{1}={2}\t", a, b,a*b);                         //九九乘法表  双 for 嵌套 实现。
            //    }
            //    Console.WriteLine();
            //}

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(intArray.GetType().FullName);
            //Console.WriteLine(intArray is Array);

            //IEnumerator enumerable = intArray.GetEnumerator();       //指月
            //while (enumerable.MoveNext ())
            //{
            //    Console.WriteLine(enumerable.Current);
            //}
            //enumerable.Reset();
            //while (enumerable.MoveNext())
            //{
            //    Console.WriteLine(enumerable.Current);
            //}

           IList<int> intList = new List<int>() { 1, 2, 3, 4,5, 6, 7, 8, 9 };
            foreach (var  current in  intList)
            {
                Console.WriteLine(current);
            }
        }
    }



    //        int score = 0;
    //        int sum = 0;
    //        do
    //        {
    //            Console.WriteLine("输入两个数字它们的和为100");
    //            Console.WriteLine("请输入第一个数字");
    //            string sta1 = Console.ReadLine();
    //            int x = 0;
    //            try
    //            {
    //                x = int.Parse(sta1);
    //            }
    //            catch
    //            {

    //                Console.WriteLine("输入数字有误请重新输入");
    //                continue;
    //            }

    //            Console.WriteLine("请输入第二个数字");
    //            string sta2 = Console.ReadLine();
    //            int y = 0;
    //            try
    //            {
    //                y = int.Parse(sta2);
    //            }
    //            catch
    //            {

    //                Console.WriteLine("输入数字错误请重新输入");
    //                continue;
    //            }

    //            sum = x + y;
    //            if (sum == 100)
    //            {
    //                score++;
    //                Console.WriteLine("正确：{0}+{1}={2}", x, y, sum);
    //            }
    //            else
    //            {
    //                Console.WriteLine("错误：{0}+{1}={2}", x, y, sum);
    //                Console.WriteLine("你的成绩是{0}", score);
    //                Console.WriteLine("GAME OVER");
    //            }
    //        } while (sum == 100);
    //Console.WriteLine("你的成绩是{0}", score);
    //Console.WriteLine("GAME OVER");






    class Box
    {
        internal static void Example()
        {
            Console.WriteLine(@"请输入一个数字，如果能被6整除就会显示“”六六顺“”，如果能被8整除就会显示“”发发发“”！");
            int x = 0;
            do
            {
                // Console.WriteLine(@"请输入一个数字，如果能被6整除就会显示“”六六顺“”，如果能被8整除就会显示“”发发发“”！");
                string str1 = Console.ReadLine();


                try
                {
                    x = int.Parse(str1);
                }
                catch
                {
                    Console.WriteLine("非法输入,请重新输入！");
                    continue;
                }

                if (x % 6 == 0)
                {
                    Console.WriteLine("六六顺");
                    if (x % 8 == 0)
                    {
                        Console.WriteLine("发发发");
                    }
                }
                else
                {
                    Console.WriteLine("大吉大利");
                }
            } while (true);
        }
    }
}
    


