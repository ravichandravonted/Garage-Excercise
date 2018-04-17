using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Car : vehicle
    {
        private string fueltype;
        public Car(string regnum, string color, int numOfwheels,bool park, string fueltype) : base(regnum, color, numOfwheels,park)
        {
            Fueltype = fueltype;
        }

        public string Fueltype
        {
            get;
            //{
            //    return Fueltype;
            //}
            set;
            //{
            //    value = Fueltype;
            //}
        }

        public override string State()
        {
            return base.State() + $" , And It Works On {Fueltype}.";
        }

    }
}
