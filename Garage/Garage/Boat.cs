using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Boat : vehicle
    {
        private double length;
        public Boat(string regnum, string color, int numOfwheels,bool park, double length) : base(regnum, color, numOfwheels,park)
        {
            Length = length;
        }
        public double Length
        {
            get;
            //{
            //    return Length;
            //}
            set;
            //{
            //    value = Length;
            //}
        }

        public override string State()
        {
            return base.State() + $",  {Length}" ;
        }

    }
}
