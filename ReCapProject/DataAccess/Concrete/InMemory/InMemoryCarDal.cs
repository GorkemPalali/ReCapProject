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
            _cars = new List<Car> {
                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=120000, ModelYear=2023, Description="Mercedes Beyaz"},
                new Car {Id=2, BrandId=1, ColorId=2, DailyPrice=110000, ModelYear=2023, Description="Mercedes Siyah"},
                new Car {Id=3, BrandId=1, ColorId=3, DailyPrice=155000, ModelYear=2020, Description="Mercedes Kırmızı"},
                new Car {Id=4, BrandId=2, ColorId=1, DailyPrice=100000, ModelYear=2022, Description="BMW Beyaz"},
                new Car {Id=5, BrandId=2, ColorId=2, DailyPrice=150000, ModelYear=2023, Description="BMW Siyah"},
                new Car {Id=6, BrandId=2, ColorId=3, DailyPrice=140000, ModelYear=2024, Description="BMW Kırmızı"},
                new Car {Id=7, BrandId=3, ColorId=1, DailyPrice=135000, ModelYear=2024, Description="Audi Beyaz"},
                new Car {Id=8, BrandId=3, ColorId=2, DailyPrice=150000, ModelYear=2022, Description="Audi Siyah"},
                new Car {Id=9, BrandId=3, ColorId=3, DailyPrice=150000, ModelYear=2022, Description="Audi Kırmızı"}
            };
        }

       
        public List<Car> GetById(int Id)
        {
           return  _cars.Where(c => c.Id ==  Id).ToList();
        }


        public List<Car> GetAll()
        {
            return _cars;
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);

        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

    }
}
