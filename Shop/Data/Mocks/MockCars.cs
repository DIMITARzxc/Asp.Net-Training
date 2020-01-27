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
                        Img ="https://delo.ua/files/news/images/3610/17/picture2_tesla-poluchila-b_361017_p0.jpg",
                        Price =45000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car{
                        Name ="BMW M3",
                        ShortDesc ="Classic from Germany",
                        LongDesc ="",
                        Img ="https://upload.wikimedia.org/wikipedia/commons/9/98/2017_BMW_M3_%28F80%29_sedan_%282018-08-31%29_01.jpg",
                        Price =30000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car{
                        Name ="Mercedes S Class",
                        ShortDesc ="Classic",
                        LongDesc ="",
                        Img ="https://autoreview.ru/images/Article/1601/Article_160194_860_575.jpg",
                        Price =35000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car{
                        Name ="Nissan Leaf",
                        ShortDesc ="Good Electro Car",
                        LongDesc ="",
                        Img ="https://rental.ua/content/rent/cars/314/nissan-leaf-340x200-82a9.png",
                        Price =15000,
                        IsFavourite =true,
                        Avalaible =true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car{
                        Name ="Lada Kalina Sport",
                        ShortDesc ="Good and inexpensive car",
                        LongDesc ="",
                        Img ="https://upload.wikimedia.org/wikipedia/commons/b/b6/Lada_Kalina_sport_1.4_MosIAS_26_08_2008.jpg",
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
