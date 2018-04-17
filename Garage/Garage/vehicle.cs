using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class vehicle
    {
        private string regnum; string color; int numOfwheels; bool park;
       
        public vehicle(string regnum, string color, int numOfwheels,bool park)
        {
            Regname = regnum;
            Color = color;
            Numofwheels = numOfwheels;
            Park = park;
        }
        public bool Park
        {
            get;
            //{
            //    return Park;
            //}

            set;
            //{
            //    Park = value;
            //}
            
        }

        public string Regname
        {
            get;
            //{
            //    return Regname;
            //}

            set;
            //{
            //    Regname = value;
            //}
        }


        public string Color
        {
            get;
            //{ return Color; }
            set;
            //{
            //    Color = value;
            //}
        }
        public int Numofwheels
        {
            get;
            //{
            //    return Numofwheels;
            //}
            set;
            //{
            //    Numofwheels = value;
            //}
        }


        public virtual string State()
        {
            return "The Vechicle Type is "+GetType().Name+", Its Number is " +Regname+", Its Color is " + Color+ ", It Has " + Numofwheels+ " Wheels, And The Park state is " + Park;
        }
    }
}

        
        
        
        
        

    

