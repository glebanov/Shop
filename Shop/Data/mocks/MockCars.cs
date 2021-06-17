using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
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
                    new Car
                    {
                        name = "Tesla Model S" ,
                        shortDesc = " Быстрый автомобиль", 
                        longDesc="Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img="https://krot.info/uploads/posts/2019-11/1574813400_tesla-model-y-42.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        Category = _carsCategory.AllCategories.First()
                    },
                      new Car
                    {
                        name = "Ford Fiesta" ,
                        shortDesc = "Тихий и спокойный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="http://neo-drive.com/images1280_/2011-ford-fiesta-12.jpg",
                        price = 5000,
                        isFavorite = false,
                        available = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                      new Car
                    {
                        name = "Трактор" ,
                        shortDesc = " Сильный и надежный ",
                        longDesc="Передвинет и потянет все, что угодно",
                        img="https://i.artfile.ru/4096x2731_1349558_[www.ArtFile.ru].jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                      new Car
                    {
                        name = "Лада Приора" ,
                        shortDesc = " Качество ",
                        longDesc="Приодолеет любые нервы даже самые крепкие",
                        img="https://a.d-cd.net/b81c469s-1920.jpg",
                        price = 400,
                        isFavorite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                      new Car
                    {
                        name = " Maserati" ,
                        shortDesc = " Быстрый и раскошный",
                        longDesc=" Безупречное сочетание передовой динамики на дороге и внедорожных возможностей",
                        img="https://avatars.mds.yandex.net/get-autoru-vos/1924530/7f3f2b4b1a536ebc521aedd93eb7f211/1200x900",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                      new Car
                    {
                        name = "Ford GT" ,
                        shortDesc = "Летит на крыльях ночи",
                        longDesc="Победитель гонок",
                        img="https://avatars.mds.yandex.net/get-zen_doc/1584427/pub_5cc688dce2e2ca00b2da206b_5cc68a8087569900b3653435/scale_1200",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },

                };
            } 
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
