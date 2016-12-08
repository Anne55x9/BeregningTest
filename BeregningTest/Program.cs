using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregningTest
{
    class Program
    {
        private double foodSumDay;
        private double envelopDay;
        private double houseSumDay;

        public double FoodSumDay 
        {
            get { return foodSumDay; }
            set { foodSumDay = value; }
        }


        public double EnvolpeDay { get; set; }
        public double HouseSumDay { get; set; }


        public double FinalSum { get; set; }
        public double UdlagtSum { get; set; }
        //public Hus HusObj { get; set; }

        public Program()
        {
           
        }

        public void AddFoodSumDay(double foodSumDay)
        {
            this.foodSumDay = foodSumDay;
        }

        public double GetEnvelopDay(int XXVoksne, int YYUnge, int ZZBørn)
        {
            envelopDay = foodSumDay / ((XXVoksne * 1) + (YYUnge * 0.5) + (ZZBørn * 0.25));
            return envelopDay;
        }

        public double GetHouseSumDay(int XVoksne, int YUnge, int ZBørn)
        {
            houseSumDay = (envelopDay * XVoksne * 1) + (envelopDay*YUnge*0.5) + (envelopDay*ZBørn*0.25);
            return houseSumDay;
        }


        static void Main()
        {
            Program hus1 = new Program();

            hus1.AddFoodSumDay(1000);
             
            Console.WriteLine($"{hus1.GetEnvelopDay(3, 4, 11)}");

            Console.WriteLine($"{hus1.GetHouseSumDay(2,3,1)}");

            Program hus2 = new Program();

            hus2.AddFoodSumDay(1000);

            Console.WriteLine($"{hus2.GetEnvelopDay(3,4,11)}");

            Console.WriteLine($"{hus2.GetHouseSumDay(1,1,0)}");

            Program hus3 = new Program();

            hus3.AddFoodSumDay(1000);

            Console.WriteLine($"{hus3.GetEnvelopDay(3,4,11)}");
            Console.WriteLine($"{hus3.GetHouseSumDay(0,0,10)}");

            Console.ReadLine();
        }

    }
}
