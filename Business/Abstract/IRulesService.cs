using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRulesService
    {
        void NameRules(Car car);
        void PriceRules(Car car);
    }
}
