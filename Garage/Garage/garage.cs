using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class garage<T> : IEnumerable<T> where T : vehicle
    {

        private T[] collection;
        int cap, count;
        public garage(int maxcapacity)
        {
            cap = maxcapacity;
            count = 0;
            collection = new T[maxcapacity];

        }
        public void Prak(T input)
        {
            if (cap > count)
            {
                collection[count] = input;
                count += 1;
            }
        }

        public void UnPark(string v)
        {

            
            for (int i = 0; i < count; i++)
            {
                if (collection[i].Regname == v)
                {
                    collection[i] = null;
                    
                 
                }

            }
        }











        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

