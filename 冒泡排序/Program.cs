using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        //冒泡排序
        static void Main(string[] args)
        {
            BubbleSort();
            Console.ReadKey();
        }

        static void BubbleSort()
        {
            //1.0定义要进行排序的数组
            int[] data = new int[] { 4, 21, 9, 8,3};
            Console.WriteLine("排序前数组:{" + string.Join(",", data) + "}");

            //2.0利用冒泡排序算法从小到大进行排列
            int dataLength = data.Length;//获取数组的长度
            int temp;//临时变量
            for (int i = dataLength-1; i >0; i--)//要比较的趟数
            {
                for (int j = 0; j < i; j++)
                {
                    //若左边》右边 交换位置
                    if (data[j]>data[j+1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("排序后数组:{" + string.Join(",", data) + "}");
        }

        //--------
        public  void BubbleSort2()
        {
            int[] data = new int[] { 1, 9, 88, 95, 5 };
            int dataLength = data.Length;
            int temp;
            for (int i = dataLength-1; i >0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[j]>data[j+1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }     
}
