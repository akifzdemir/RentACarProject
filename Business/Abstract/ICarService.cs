﻿using Entitites.Concrete;
using Entitites.DTOs;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int BrandId);
        IDataResult<List<Car>> GetCarsByColorId(int ColorId);
        IDataResult<Car> GetById(int id); 
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IDataResult<CarDetailsDto> GetCarDetailById(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetailsByBrandId(int brandId);
        IDataResult<List<CarDetailsDto>> GetCarDetailsByColorId(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
