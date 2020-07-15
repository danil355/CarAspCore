using DZ_CAR.Models;
using DZ_CAR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_CAR.Services.Implementations
{
    public class Repository : IRepository
    {
        private readonly IList<Car> _cars; // использовать DbContext вместо списка

        public Repository()
        {
            _cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    Kuzov = Kuzov.Sedan,
                    Brand = "Mercedes Benz S600",
                    Color = System.Drawing.Color.White,
                    Power = 1000
                },
           
                new Car()
                {
                    Id = 2,
                    Kuzov = Kuzov.Limousine,
                    Brand = "Limousine Chrysler",
                    Color = System.Drawing.Color.Black,
                    Power = 500
                }
            };
        }

        public void Create(Car car)
        {
            _cars.Add(car);
        }

        public void Edit(Car car)
        {
            var car1 = _cars.FirstOrDefault(x => x.Id == car.Id);
            car1.Brand = car.Brand;
            car1.Kuzov = car.Kuzov;
            car1.Color = car.Color;
            car1.Power = car.Power;
        }

        public void Delete(Car car)
        {
            _cars.Remove(car);
        }

        public Car Get(int id)
        {
            return _cars.First(x => x.Id == id);
        }

        public IList<Car> GetAll()
        {
            return _cars;
        }

        public void Delete(int id)
        {
            _cars.Remove(_cars.FirstOrDefault(x => x.Id == id));
        }
    }
}
