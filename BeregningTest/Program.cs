using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregningTest
{
    public class Program
    {

        static void Main(string[] args)
        {
            ///Making a list using the class Hus as type.
            List<Hus> Total = new List<Hus>();

            /// Calling Hus object hus1, hus2, hus3 with specific parameters. The Add and Set methods must be envoked as it is now. 

            Hus hus1 = new Hus(2,3,1);
            hus1.AddFoodSumDay(1000);
            hus1.SetEnvelopDay(3,4,11);
              
            Hus hus2 = new Hus(1,1,0);
            hus2.AddFoodSumDay(1000);
            hus2.SetEnvelopDay(3,4,11);

            Hus hus3 = new Hus(0,0,10);
            hus3.AddFoodSumDay(1000);
            hus3.SetEnvelopDay(3,4,11);

            //Adding the object hus1, hus2, hus3 to the list Total;

            Total.Add(hus1);
            Total.Add(hus2);
            Total.Add(hus3);

            ///Running through the list of Hus objects. 
            ///Foreach Hus object in the list the Sum for the House on a given dinner day is calculated.

            foreach (Hus h in Total)
            {
                Console.WriteLine($"Prisen for mandag er i boligen:{h.GetHouseSumDay()} kr");
                
            }

            ///Calls the method to balance the acounts for all houses in the Hus object list.

            Console.WriteLine( $"Hus 1 konto er: {hus1.GetExpensesBalencedDay(0)}, hus 2 konto er: {hus2.GetExpensesBalencedDay(0)}, hus 3 konto er:{hus3.GetExpensesBalencedDay(1000)}");

            ///Summen af Husene skal valideres med indkøbsUdlæget.

            Console.ReadLine();
        }

    }
}
