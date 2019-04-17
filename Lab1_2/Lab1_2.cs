using System;

namespace Lab1_2
{
    class Program
    {
        public static void Compare(int[] a, int n)
        {
            n = a.Length;
            int max = a[0];
            for (int i = 0; i < n; i++)
                if (a[i] > max)
                    max = a[i];
            Console.WriteLine("max is {0}.", max);
        }
        public static void First()
        {
            Random r = new Random();
            int[] a = { 0, 0, 0 };
            Console.Write("（1）随机3个数：");
            for (int i = 0; i < 3; i++)
            {
                a[i] = r.Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Compare(a, 3);
        }

        //生成一个 0~100 之间的随机实数，并显示；
        static void Second()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int i = r.Next(0, 100000000);
            Console.WriteLine("（2）0~100之间的随机数：{0}", (double)i / 1000000);
        }

        //生成一个 20~50 之间的随机实数，并显示
        static void Three()
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random r = new Random(seed);
            int i = r.Next(0, 1000000);
            double x = (double)i / 1000000;
            int a = r.Next(20, 49);
            Console.WriteLine("（3）20~50之间的随机数：{0}", a + x);
        }
        static void Main(string[] args)
        {
            int switch_on = 0;
            while (true)
            {
                Console.Write("选择第2题的小题（选择 1、2、3 ,按其余数字退出）:->>  ");

                switch_on = Convert.ToInt32(Console.ReadLine());

                switch (switch_on)
                {
                    case 1: First(); break;
                    case 2: Second(); break;
                    case 3: Three(); break;
                }
                if (switch_on != 1 && switch_on != 2 && switch_on != 3)
                    break;
            }
            //Main里调用方法没有使用对象，各方法前必须代static 
        }
    }
}
