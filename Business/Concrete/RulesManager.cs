using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RulesManager : IRulesService
    {
        public void NameRules(Car car)
        {
            if(car.Description.Length < 2)
            {
                throw new Exception("Araba ismi minimum 2 karakter olmalıdır!!!");
            }
        }

        public void PriceRules(Car car)
        {
            if(car.DailyPrice < 0)
            {
                throw new Exception("Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
            
        }
    }
}
