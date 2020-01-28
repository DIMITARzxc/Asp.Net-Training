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
                    new Car{
                        Name ="Tesla",
                        ShortDesc ="Good Car",
                        LongDesc ="",
                        Img ="/Img/tesla.jpg",
                        Price =45000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car{
                        Name ="BMW M3",
                        ShortDesc ="Classic from Germany",
                        LongDesc ="",
                        Img ="~/Img/bmw.jpg",
                        Price =30000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car{
                        Name ="Mercedes S Class",
                        ShortDesc ="Classic",
                        LongDesc ="",
                        Img ="/Img/mercedes.jpg",
                        Price =35000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car{
                        Name ="Nissan Leaf",
                        ShortDesc ="Good Electro Car",
                        LongDesc ="",
                        Img ="/Img/nissan.png",
                        Price =15000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car{
                        Name ="Lada Kalina Sport",
                        ShortDesc ="Good and inexpensive car",
                        LongDesc ="",
                        Img ="/Img/lada.jpg",
                        Price =10000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.Last()
                    },
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
