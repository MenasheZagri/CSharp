using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Garage : IGarage, IEnumerable<Car>
    {
        private List<Car> cars = new List<Car>();
        private List<string> carTypes = new List<string>{"Mazda", "Ford"};

        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }

        public void AddCar(Car car)
        {

            if (car == null)
            {
                throw new CarNullException();
            }
            if (car.Brand != carTypes.ToString())
            {
                throw new WrongGarageException($"{car.Brand} is not a part of our cars");
            }

            

            if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException($"Unable to fix {car.Brand} doesn't need repair");
            }
            if (car.TotalLost == true)
            {
                throw new WeDoNotFixTotalLossCarsException($"Unable to fix {car.Brand} total loss");
            }
            cars.Add(car); 
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }
        public void FixCar(Car car)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Car> GetEnumerator()
        {
            List<Car> allCars = new List<Car>();
            allCars.AddRange(cars);
            return allCars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
