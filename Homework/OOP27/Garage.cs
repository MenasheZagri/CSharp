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
        private List<string> carTypes = new List<string> {"Mazda", "Ford"};


        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }

        public void AddCar(Car car)
        {
            Console.WriteLine($"Adding {car.Brand} to list");
            if (car == null)
            {
                throw new CarNullException();
            }

            if (!carTypes.Contains(car.Brand))
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
            Console.WriteLine($"{car.Brand} added to list");
        }

        public void RemoveCar(Car car)
        {
            Console.WriteLine($"Removing / releasing {car.Brand} from list / garage");

            if (car == null)
            {
                throw new CarNullException();
            }

            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException($"{car.Brand} is not a part of our cars");
            }

            if (car.NeedsRepair == true)
            {
                throw new RepairMismatchException($"Unable to release / remove {car.Brand} still needs repair");
            }

            cars.Remove(car);
            Console.WriteLine($"{car.Brand} removed list");

        }

        public void FixCar(Car car)
        {
            Console.WriteLine($"Fixing {car.Brand} ");

            if (car.NeedsRepair == true)
            {
                if (car == null)
                {
                    throw new CarNullException();
                }

                if (!carTypes.Contains(car.Brand))
                {
                    throw new WrongGarageException($"{car.Brand} is not a part of our cars");
                }

                Console.WriteLine($"{car.Brand} has been fixed");
                car.NeedsRepair = false;
            }
            else
                throw new RepairMismatchException($"Unable to fix {car.Brand} doesn't need repair");
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
