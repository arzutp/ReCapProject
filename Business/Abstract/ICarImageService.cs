using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarId(int id);

        IResult Add(IFormFile fromFile, CarImage carImage);
        IResult Update(IFormFile fromFile, CarImage carImage);
        IResult Delete( CarImage carImage);
    }
}
