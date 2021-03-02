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
        
        static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new EfCarDal());
            IBrandService brandManager = new BrandManager(new EfBrandDal());
            IColorService colorManager = new ColorManager(new EfColorDal());
            //CarTest(carManager);
            //BrandTest(brandManager);
            //ColorTest(colorManager);

            


            System.Console.WriteLine("------join işlemi sonucu gelen değerler----------");
            var result = carManager.GetCarDetails();
            
            foreach (var item in result.Data)
                {
                    System.Console.WriteLine("{0} / {1} / {2} / {3}", item.BrandName, item.Description, item.DailyPrice, item.ColorName);

                }
            
            


            Color color = new Color { ColorName = "Mor" };
                colorManager.Add(color);
            var result1 = colorManager.GetAll();
            System.Console.WriteLine("-----tüm renkler----------");
                foreach (var item in result1.Data)
                {
                    System.Console.WriteLine(item.ColorName);
                }


        }




        //private static void ColorTest(IColorService colorManager)
        //{
        //    Color color = new Color { ColorName = "Mor" };
        //    colorManager.Add(color);

        //    System.Console.WriteLine("-----tüm renkler----------");
        //    foreach (var item in colorManager.GetAll())
        //    {
        //        System.Console.WriteLine(item.ColorName);
        //    }
        //}

        //private static void BrandTest(IBrandService brandManager)
        //{
        //    Brand brand = new Brand { BrandName = "Bugatti" };
        //    brandManager.Add(brand);
        //    System.Console.WriteLine("------tüm araba markaları------");
        //    foreach (var item in brandManager.GetAll())
        //    {
        //        System.Console.WriteLine(item.BrandName);
        //    }

        //    brandManager.Update(new Brand { BrandId = 1002, BrandName = "BMV" });
        //    System.Console.WriteLine("------güncelleme sonrası tüm araba markaları------");
        //    foreach (var item in brandManager.GetAll())
        //    {
        //        System.Console.WriteLine(item.BrandName);
        //    }

        //    brandManager.Delete(new Brand { BrandId = 1005 });
        //    System.Console.WriteLine("------silme işlemi sonrası tüm araba markaları------");
        //    foreach (var item in brandManager.GetAll())
        //    {
        //        System.Console.WriteLine(item.BrandName);
        //    }
        //}

        //private static void CarTest(ICarService carManager)
        //{

        //    Car car = new Car() { BrandId = 2, ColorId = 2, DailyPrice = 200, Description = "BMV", ModelYear = 2009 };
        //    carManager.Add(car);

        //    System.Console.WriteLine("------Tüm arabaların açıklamaları------");
        //    foreach (var item in carManager.GetAll())
        //    {
        //        System.Console.WriteLine(item.Description);
        //    }
        //    carManager.Update(new Car { CarId = 1002, BrandId = 2, ColorId = 3, DailyPrice = 500, Description = "Aile", ModelYear = 2015 });

        //    System.Console.WriteLine("------Güncelleme yapıldıktan sonra tüm arabaların açıklamaları------");
        //    foreach (var item in carManager.GetAll())
        //    {
        //        System.Console.WriteLine(item.Description);
        //    }
        //    System.Console.WriteLine("----id ile getirme-----");
        //    foreach (var item in carManager.GetCarsByBrandId(2))
        //    {
        //        System.Console.WriteLine(item.Description);
        //    }

        //}
    }
}
