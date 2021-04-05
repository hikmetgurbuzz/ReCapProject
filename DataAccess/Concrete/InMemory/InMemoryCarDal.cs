using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{ CarId=1, BrandId=1, ColorId=1, ModelYear=2018, DailyPrice=900, CarName="Audi", Description="A3 Sedan 1.6 TDI" },
                new Car{ CarId=2, BrandId=2, ColorId=2, ModelYear=2017, DailyPrice=800, CarName="BMW", Description="116d Joy Plus" },
                new Car{ CarId=3, BrandId=3, ColorId=3, ModelYear=2016, DailyPrice=750, CarName="Mercedes", Description="C 180 AMG 7G-Tronic" },
                new Car{ CarId=4, BrandId=3, ColorId=3, ModelYear=2018, DailyPrice=950, CarName="Mercedes", Description="E 180 AMG" },
                new Car{ CarId=5, BrandId=4, ColorId=1, ModelYear=2018, DailyPrice=850, CarName="Ford", Description="Focus 1.5 TDCi Trend X" }
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarName = car.CarName;
            carToUpdate.Description = car.Description;
        }
    }
}
