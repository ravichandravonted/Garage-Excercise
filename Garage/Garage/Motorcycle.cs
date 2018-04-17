using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Motorcycle : vehicle
    {
        private double volofCylinder;
        public Motorcycle(string regnum, string color, int numOfwheels,bool park, double volofCylinder) : base(regnum, color, numOfwheels,park)
        {
            VolofCylinder = volofCylinder;
        }
        public double VolofCylinder
        {
            get;
            //{
            //    return VolofCylinder;
            //}
            set;
            //{
            //    value = VolofCylinder;
            //}
        }

        public override string State()
        {
            return base.State() + $", And It is {VolofCylinder} CC." ;
        }
    }
}
