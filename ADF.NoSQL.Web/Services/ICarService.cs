using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADF.NoSQL.Web.Models;

namespace ADF.NoSQL.Web.Services
{
    public interface ICarService
    {
        List<Car> Get();
        Car Get(string id);
        Car Create(Car car);
        void Update(string id, Car carIn);
        void Remove(Car carIn);
        void Remove(string id);
    }
}
