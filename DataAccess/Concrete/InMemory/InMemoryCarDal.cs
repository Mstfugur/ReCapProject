using DataAccess.Abstract;
using Entities.Absract;
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
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2021", DailyPrice = 15000, Description = "Bmw 300x" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2020", DailyPrice = 25000, Description = "Mercedes Benz" }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public Car GetById(int Id)
        {
            return _car.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car carUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            car.BrandId = carUpdate.BrandId;
            car.ColorId = carUpdate.ColorId;
            car.DailyPrice = carUpdate.DailyPrice;
            car.Description = carUpdate.Description;
            car.ModelYear = carUpdate.ModelYear;

           
        }

       
    }
}
