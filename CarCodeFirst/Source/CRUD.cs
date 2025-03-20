using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarCodeFirst.Data;
using CarCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CarCodeFirst.Source
{
    public class CRUD
    {
        // CREATE
        public void AddRecord(Car car)
        {
            Records.carContext.Cars.Add(car);
            Records.carContext.SaveChanges();
        }

        // READ
        public ICollection<Car> GetCars()
        {
            return Records.carContext.Cars.ToList();
        }

        public Car GetCar(int vin)
        {
            return Records.carContext.Cars.Find(vin);
        }

        public Car GetUniqueCar(int vin)
        {
            return (Car)Records.carContext.Cars.Where<Car>(car => car.VIN == vin);
        }

        // UPDATE
        public void UpdateRecord(int vin, Car car)
        {
            var carFound = Records.carContext.Cars.Find(vin);
            if(carFound != null)
            {
                carFound.Price = car.Price;
                carFound.Make = car.Make;
                carFound.Model = car.Model;
                carFound.Year = car.Year;

                Records.carContext.SaveChanges();
            }
        }

        // DELETE
        public void DeleteRecord(int vin)
        {
            var carFound = Records.carContext.Cars.Find(vin);
            if (carFound != null)
            {
                Records.carContext.Cars.Remove(carFound);
                Records.carContext.SaveChanges();
            }
        }

        // HELPER ID
        public int GetUnusedId()
        {
            return 1 + Records.carContext.Cars.Max<Car>(car => car.VIN);
        }
    }
}
