using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Decompose
    {
        static uint[] iArray;

        private static void Integer_Decompose(uint n, uint k)
        {
            uint i = (n < iArray[k - 1]) ? n : iArray[k - 1];
            while (i > 0)
            {
                iArray[k] = i;
                if (i == n)
                {
                    Console.Write("\r\n{0} = {1}", iArray[0], iArray[1]);
                    for (uint j = 2; j <= k; j++)
                        Console.Write(" + {0}", iArray[j]);
                }
                else
                    Integer_Decompose(n - i, k + 1);
                i--;
            }
        }
        //在主方法中要求用户输入一个正整数 n，如果输入不正确则要求重新输入
        static void Main(string[] args)
        {
            iArray = new uint[100];
            uint n = 0;
            Console.WriteLine("Please input an integer:");
            n = Convert.ToUInt32(Console.ReadLine());
            while (n < 1)
            {
                Console.Write("不正确, 重input :->> ");
                n = Convert.ToUInt32(Console.ReadLine());
            }
            iArray[0] = n;
            Integer_Decompose(n, 1);
            Console.WriteLine();
        }
    }
}