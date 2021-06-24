using System;

namespace VehicleLot
{
    class Program
    {
        public class Vehicle 
        {
            protected int wheels(int count)
            {
                return 4;
            }

            protected int doors(int count)
            {
                return 2;
            }
        }
        public class Car : Vehicle
        {
            public void doorCount()
            {
                doors(4);
            }
        }

        public class Semi : Vehicle
        {
            public void wheelCount()
            {
                wheels(18);
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car();
            // myCar.wheelCount();
            myCar.doorCount();


            Console.WriteLine(myCar);
            // BaseClass myBase = new BaseClass();
        }
    }
}
