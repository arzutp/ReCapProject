using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new EfCarDal(), new RulesManager());
            IBrandService brandService = new BrandManager(new EfBrandDal());
            IColorService colorService = new ColorManager(new EfColorDal());

            Car car = new Car() { BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "Audi", ModelYear = 2009 };

            carManager.Add(car);

            foreach(var item in carManager.GetAll())
            {
                System.Console.WriteLine(item.Description);
            }
            


        }
    }
}
