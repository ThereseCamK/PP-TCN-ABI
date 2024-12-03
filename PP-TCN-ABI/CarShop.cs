using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_TCN_ABI
{
    internal class CarShop
    {

        public List<Car> cars = new List<Car>();

        public CarShop() { }

        public void addCar(Car car)
        {
            cars.Add(car);
        }

        public void showAllCars()
        {
            foreach (Car car in cars) {
                Console.WriteLine($"Merke: {car.brand} ");
                Console.WriteLine($"Modell: {car.brandName} ");
                Console.WriteLine($"Km: {car.km} ");
                Console.WriteLine($"Årstall: {car.yearModel} ");
                Console.WriteLine($"RegNr: {car.regNr} ");
                Console.WriteLine($"...........................");
            }
        }

        public void showCarsByBrand(string brand)
        {
            List<Car> carsByBrand = new List<Car>();
            for (int i = 0; i < cars.Count; i++) {
                if (cars[i].brand == brand) {
                    carsByBrand.Add(cars[i]);
                }
            }

            printCarsByBrand(carsByBrand);
        }

        public void showCarsByKm()
        {

        }

        public void showCarsByYear()
        {

        }

        void printCarsByBrand(List<Car> cars)
        {
            Console.Clear();
            foreach (Car car in cars)
            {
                Console.WriteLine($"Merke: {car.brand} ");
                Console.WriteLine($"Modell: {car.brandName} ");
                Console.WriteLine($"Km: {car.km} ");
                Console.WriteLine($"Årstall: {car.yearModel} ");
                Console.WriteLine($"RegNr: {car.regNr} ");
                Console.WriteLine($"...........................");
            }
           
        }
    }
}
