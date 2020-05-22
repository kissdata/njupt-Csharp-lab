using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 对实验1定义的复数类，利用操作符重载来实现复数的加减乘除 */
namespace Lab2_1
{
    class Complex
    {
        private int shi;
        private int xu;

        public Complex()
        { shi = 0; xu = 0; }
        public Complex(int a, int b)
        {
            shi = a;
            xu = b;
        }

        public static Complex operator +(Complex d1, Complex d2)
        {
            return new Complex(d1.shi + d2.shi, d1.xu + d2.xu);
        }
        public static Complex operator -(Complex d1, Complex d2)
        {
            return new Complex(d1.shi - d2.shi, d1.xu - d2.xu);
        }
        public static Complex operator *(Complex d1, Complex d2)
        {
            return new Complex(d1.shi * d2.shi - d1.xu * d2.xu, d1.xu * d2.shi + d1.shi * d2.xu);
        }
        public void Add(Complex x)
        {
            shi += x.shi;
            xu += x.xu;
        }

        public void Minus(Complex x)
        {
            shi -= x.shi;
            xu -= x.xu;
        }

        public void Multiple(Complex x)
        {
            Complex c = new Complex(0, 0);
            c.shi = this.shi * x.shi - this.xu * x.xu;
            c.xu = this.xu * x.shi + this.shi * x.xu;
            this.shi = c.shi;
            this.xu = c.xu;
        }

        /*
         *  (a+bi)(c+di)=
         *  (ac-bd)+(bc+ad)i    考虑bc+ad的正负
         */
        public void Output()
        {
            if (xu > 0)
                Console.WriteLine(shi + "+" + xu + "i");
            else
                Console.WriteLine(shi + "" + xu + "i");
        }
    }
    class TestComplex
    {
        static void Main(string[] args)
        {
            Complex A1 = new Complex(2, 3);
            Complex A2 = new Complex(2, 3);
            Complex A3 = new Complex(2, 3);
            Complex B = new Complex(4, 5);
            A1.Add(B);
            A1.Output();
            A2.Minus(B);
            A2.Output();
            //     A3.Multiple(B);
            //     A3.Output();
            A3 = A1 + A2;
            A3.Output();
            A3 = A2 - B;
            A3.Output();
        }
    }

}
