using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        // method

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Jono sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("Jono selesai mengantar penumpang");
        }
    }
}
