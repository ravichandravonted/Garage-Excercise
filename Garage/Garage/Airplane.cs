using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Airplane : vehicle
    {
        private int numofEngines;


        public Airplane(string regnum, string color, int numOfwheels,bool park, int numofEngines) : base(regnum, color, numOfwheels,park)
        {

            NumofEngines = numofEngines;


        }


        public int NumofEngines
        {
            get;
            //{ return NumofEngines; }
            set;
            //{
            //    NumofEngines = value;
            //}
        }

        public override string State()
        {
            return base.State() + $",  And It Has {NumofEngines} Engines.";
        }
    }
}
