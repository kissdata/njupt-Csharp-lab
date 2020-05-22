using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chapter 5 activity  —— Order-processing System Using Abstract Classes
namespace FFC
{
    public abstract class Furniture
    {
        protected string color;
        protected int width;
        protected int height;
        public abstract void Accept();
        public abstract void Display();
        // Abstract methods cannot contain any method body. P5.9
    }
    class Bookshelf : Furniture
    {
        private int numOf_shelves;
        public override void Accept()
        {
            string str2, str3, str4;
            Console.WriteLine("Enter values for Bookshelf");

            Console.WriteLine("Enter color ");
            color = Console.ReadLine();

            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);

            Console.WriteLine("Enter height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);

            Console.WriteLine("Enter No. of shelves ");
            str4 = Console.ReadLine();
            numOf_shelves = Convert.ToInt32(str4);
        }
        //父类是抽象类且有抽象方法（抽象类中可以没有抽象方法）的时候
        //子类要么必须重写父类的抽象方法（可以是空body），要么本身也是抽象类。
        public override void Display()
        {
            Console.WriteLine("Display values for Bookshelf");
            Console.WriteLine("Color is {0}\nWidth is {1}\nHeight is {2}\n" +
                "Number of shelves is {3}", color, width, height, numOf_shelves);
        }
    }

    class Chair:Furniture
    {
        private int numOf_legs;

        public override void Accept()
        {
            string str2, str3, str4;
            Console.WriteLine("Enter values for Chair");

            Console.WriteLine("Enter color ");
            color = Console.ReadLine();

            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);

            Console.WriteLine("Enter height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);

            Console.WriteLine("Enter No. of legs in a chair ");
            str4 = Console.ReadLine();
            numOf_legs = Convert.ToInt32(str4);
        }

        public override void Display()
        {
            Console.WriteLine("Display values for Chair");
            Console.WriteLine("Color is {0}\nWidth is {1}\nHeight is {2}\n" +
                "Number of shelves is {3}", color, width, height, numOf_legs);
        }
    }

    class BookShelfChair
    {
        static int Main(String[] args)
        {
            Bookshelf b1 = new Bookshelf();
            Chair c1 = new Chair();
            b1.Accept();
            b1.Display();
            c1.Accept();
            c1.Display();

            return 0;
        }
    }
}