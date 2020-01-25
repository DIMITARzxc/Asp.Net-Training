using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{Name="Tesla", ShortDesc="", LongDesc="", Img="", Price=45000, IsFavourite=true, Avalaible=true, Category = _carsCategory.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Car> GetFavoriteCars { get; set; }

        public Car GetObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
