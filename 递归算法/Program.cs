using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归算法
{
    class Program
    {
        //*****计算数组{ 1,1,2,3,5,8.......} 第30位值*****

        static void Main(string[] args)
        {
            // NotRecursion();


            
            Console.WriteLine(NoRecurNin(1));
            Console.WriteLine(NoRecurNin(2));
            Console.WriteLine(NoRecurNin(3));
            Console.WriteLine(NoRecurNin(4));

            Console.ReadKey();
        }
        //1.0不用递归的实现方法
        static void NotRecursion()
        {
            int[] num = new int[30];
            num[0] = 1;
            num[1] = 1;
            int first = num[0];
            int second = num[1];
            for (int i = 2; i < num.Length; i++)
            {
                num[i] = first + second;
                first = second;
                second = num[i];

            }
            Console.WriteLine(num[5]);
        }
        //2.0采用递归的实现方法
        static int Recursion(int i)
        {
            if (i <= 0) return 1;
            if (i > 0 && i < 2) return 1;
            else return Recursion(i - 2) + Recursion(i - 1);
        }


        #region 计算1+2+3+4+...+100的值

        static int NoRecurHun(int num)
        {
            int result = 0;
            for (int i = 0; i <=num; i++)
            {
                result += i;
            }
            return result;
        }
        
        static int RecurHun(int num)
        {
            if (num== 0) return 0;
            return RecurHun(num - 1) + num;
        }
        #endregion

        #region 计算1 -2 +3 -4+ 5- 6 + 7 - 8 + 9的值
        static int NoRecurNin(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                if (i%2==0)
                {
                    sum-=i;
                }
                else
                {
                    sum += i;
                }
            }
            return sum;
        }

        static int RecurNin(int num)
        {
            int temp = num;
            if (num == 1) return 1;
            if (num % 2 == 0) num = -num;
            return RecurNin(temp - 1) + num;
        } 
        #endregion
    }
}
