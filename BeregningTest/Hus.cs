using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregningTest
{
     public class Hus
    {

        /// <summary>
        /// Private fields
        /// </summary>
        private double _foodSumDay;
        private double _envelopDay;
        private double _houseSumDay;

        /// <summary>
        /// Public properties
        /// </summary>

        public int XVoksne { get; set; }
        public int YUnge { get; set; }
        public int Zbørn { get; set; }

        public double FoodSumDay { get; set; }
        public double EnvelopDay { get; set; }
        public double HouseSumDay { get; set; }
        public double ExpensesDay { get; set; }

       /// <summary>
       /// Constructor initiates an instance Hus. It takes the parameter;
       /// </summary>
       /// <param name="xVoksne"></param>
       /// <param name="yUnge"></param>
       /// <param name="zbørn"></param>

        public Hus(int xVoksne, int yUnge, int zbørn)
        {
            this.XVoksne = xVoksne;
            this.YUnge = yUnge;
            this.Zbørn = zbørn;
        }

        /// <summary>
        /// Method to Add the receipt cost for a given day to an instance Hus.
        /// </summary>
        /// <param name="_foodSumDay"></param>

        public void AddFoodSumDay(double _foodSumDay)
        {
            this._foodSumDay = _foodSumDay;
        }

        /// <summary>
        /// Method to Set the Envelop per person per day. It takes tree parameters, 
        /// which are the Total of Voksne, Unge og børn that day.
        /// </summary>
        /// <param name="XXVoksne"></param>
        /// <param name="YYUnge"></param>
        /// <param name="ZZBørn"></param>

        public void SetEnvelopDay(int XXVoksne, int YYUnge, int ZZBørn)
        {
            
            _envelopDay = _foodSumDay / ((XXVoksne * 1) + (YYUnge * 0.5) + (ZZBørn * 0.25));           
        }

        /// <summary>
        /// Method to Get the envelop sum in 1 house hold a given dinner night. 
        /// The constructor takes parameters which are used in this method.
        /// </summary>
        /// <returns></returns>

        public double GetHouseSumDay()
        {   
            _houseSumDay = (_envelopDay * XVoksne * 1) + (_envelopDay * YUnge * 0.5) + (_envelopDay * Zbørn * 0.25);
            return _houseSumDay;
        }

        /// <summary>
        /// Method to Get balance in who buys and who eats. The number will level out over time. 
        /// </summary>
        /// <param name="expensesDay"></param>
        /// <returns></returns>

        public double GetExpensesBalencedDay(double expensesDay)
        {
            expensesDay = expensesDay - _houseSumDay;
            return expensesDay;
        }

       
    }
}
