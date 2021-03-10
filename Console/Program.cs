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
            //RentalCar();

            IUserService userManager = new UserManager(new EfUserDal());
            var userdeneme = userManager.GetAll();
            foreach (var item in userdeneme.Data)
            {
                System.Console.WriteLine(item.LastName);
            }
            
            //ICarService carManager1 = new CarManager(new EfCarDal());
            //var a = carManager1.GetAll();

            //foreach (var item in a.Data)
            //{
            //    System.Console.WriteLine(item.CarId);
            //}
            //System.Console.WriteLine(a.Success);

            //System.Console.WriteLine("--------id ile-----------");

            //var iddeneme = brandManager.Get(2);
            //var deneme = iddeneme.Data;
            //System.Console.WriteLine(deneme.BrandName);
            


           

            //var a1 = brandManager.GetAll();
            //foreach (var item in a1.Data)
            //{
            //    System.Console.WriteLine(item.BrandId);
            //}

            //System.Console.WriteLine("-----------------");
            //carManager.Update(new Car { CarId = 1002, BrandId = 2, ColorId = 3, DailyPrice = 500, Description = "kgkjbgkjbkjbk", ModelYear = 2015 });

            //System.Console.WriteLine("------Güncelleme yapıldıktan sonra tüm arabaların açıklamaları------");
            //var updatecar = carManager.GetAll();
            //System.Console.WriteLine(updatecar.Message);
            //foreach (var item in updatecar.Data)
            //{
            //    System.Console.WriteLine(item.Description);
            //}

            //System.Console.WriteLine("------join işlemi sonucu gelen değerler----------");

            //var result = carManager.GetCarDetails();

            //foreach (var item in result.Data)
            //    {
            //        System.Console.WriteLine("{0} / {1} / {2} / {3}", item.BrandName, item.Description, item.DailyPrice, item.ColorName);

            //    }




            


        }

        private static void RentalCar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1002, CustomerId = 2, RentDate = DateTime.Now, 
                ReturnDate = new DateTime(2021, 04, 12) });
            System.Console.WriteLine(result.Message); 
        }



        

        
    }
}
