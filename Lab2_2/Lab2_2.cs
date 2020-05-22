using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    abstract class RentedVehicle
    {
        private double baseFree;    //租车的基础费用
        public double BaseFree
        {
            get;
            set;
        }
        public RentedVehicle(double baseFree)
        {
            this.baseFree = baseFree;
        }
        public RentedVehicle()
        {

        }
        public abstract double CostToRent();    //返回租车的总费用
    }

    class Bicycle : RentedVehicle
    {
        private double nbHours; //租车时间
        public double NBHours
        {
            get { return nbHours; }
            set { nbHours = value; }
            //读写属性是同时包括get访问器和set访问器的属性
            //get访问器定义对数据访问，set访问器定义对数据的读取。
        }
        //子类不能直接调用抽象类的构造函数
        public Bicycle(double nbHours)
        {
            //调用父类的构造方法进行初始化
            this.nbHours = nbHours;
            BaseFree = 20;        //隐式调用基类无参构造函数
        }
        public override double CostToRent()
        {

            return BaseFree * nbHours;
        }
    }

    class FuelVehicle:RentedVehicle
    {
        private double nbKms;
        public double NbKms
        {
            get { return nbKms; }
            set { nbKms = value; }
        }
        public FuelVehicle(double nbKms, double baseFree):base(baseFree)
        {
            baseFree = 90;
            this.nbKms = nbKms;
        }
        public FuelVehicle()
        {
            BaseFree = 90;
        }
        public double getMileageFees()
        {
            if (nbKms < 100)
                return 0.2 * nbKms;
            else if (nbKms >= 100 && nbKms <= 400)
                return 0.3 * nbKms;
            else
                return 0.4 * nbKms + 0.5 * (nbKms - 400);
        }

        public override double CostToRent()
        {
            throw new NotImplementedException();
        }
    }

    class Car:FuelVehicle
    {
        private int nbSeats;
        public int NBSeats
        {
            get
            {
                return nbSeats;
            }
            set
            {
                nbSeats = value;
            }
        }
        public Car(int nbSeats, double nbKms):base()
        {
            this.nbSeats = nbSeats;
            NbKms = nbKms;
            BaseFree = 90;
        }
        public override double CostToRent()
        {
            return BaseFree * nbSeats + getMileageFees();
        }
    }

    class Test
    {
        //显示每一辆车子的租车费用
        public static void displayFee(RentedVehicle r)
        {
            
            Console.WriteLine();
        }
        public static void Main(String[] args)
        {
            Bicycle b1 = new Bicycle(4); 
            Car c1 = new Car(6, 50);
            displayFee(b1);
        }
    }
}
 