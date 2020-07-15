using DZ_CAR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_CAR.Services.Interfaces
{
    public interface IRepository
    {
        void Create(Car car);

        void Edit(Car car);

        void Delete(int id);

        Car Get(int id);

        IList<Car> GetAll();
    }
}
