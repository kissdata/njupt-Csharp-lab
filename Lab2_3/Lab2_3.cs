using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//输入一个字符串，判断回文
namespace Lab2_3
{
    class Lab2_3
    {
        public static void Main(String[] args)
        {
            bool i=true;
            while (i)
            {                
                Console.WriteLine("输入一个字符串");
                string a = Console.ReadLine();

                int n1 = 0, n2 = a.Length-1, k=0;
                for (; n1<n2; n1++, n2--)
                {
                    if (a[n1] != a[n2])
                    {
                        k = 1;
                        break;
                    }
                }
                if (k == 0)
                    Console.WriteLine("是");
                else
                    Console.WriteLine("不是");
                Console.WriteLine("继续？按数字0退出，其余数字继续，按字母会出错...");
                if (Convert.ToInt32(Console.ReadLine()) == 0)
                    i = false;
            }
        }
    }
}

