using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Bus : vehicle
    {

        private int numofseats;
        public Bus(string regnum, string color, int numOfwheels,bool park, int numofseats) : base(regnum, color, numOfwheels,park)
        {
            Numofseats = numofseats;

        }
        public int Numofseats
        {
            get;
            //{
            //    return Numofseats;
            //}
            set;
            //{
            //    value = Numofseats;
            //}
        }

        public override string State()
        {
            return base.State() + $",  {Numofseats}";
        }
    }
}
