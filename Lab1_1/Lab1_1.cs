using System;

namespace Lab1_1
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
            A3.Multiple(B);
            A3.Output();
        }
    }
}