using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
namespace Lab4_1
{
    class Test1
    {
        public static void ChildThread()
        {
            Console.WriteLine("子线程执行");
        }
        public static void ChildThread(Object a)
        {
            Console.WriteLine("有输入参数");
        }
        public static void Main(string[] args)
        {           

            ParameterizedThreadStart ChildRef = new ParameterizedThreadStart(ChildThread);
            Thread child_t = new Thread(ChildRef);
            child_t.Start();
        }
    }
}
