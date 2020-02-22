using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    //Declare class & inherent IEnumerable interface and specify the return object type
    //Declare generic type class and IEnumerable interface
    class Garage<T> : IEnumerable<T>
    {
        private List<T> carHeavyTreatment = new List<T>();
        private List<T> carLightTreatment = new List<T>();
        private List<T> bikeLightTreatment = new List<T>();

        //Int indexer
        public T this[int index]
        {
            get
            {
                if (carHeavyTreatment.Count > index)
                    return carHeavyTreatment[index];
                return carLightTreatment[index - carHeavyTreatment.Count];
            }
        }
        public void AddHeavy(T parameter)
        {
            carHeavyTreatment.Add(parameter);
        }

        public void AddLight(T parameter)
        {
            carLightTreatment.Add(parameter);
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> allCars = new List<T>(carHeavyTreatment);
            allCars.AddRange(carLightTreatment);
            return allCars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
