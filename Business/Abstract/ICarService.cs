﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetById(int id);
        IDataResult <List<Car>>GetByDailyPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsDetails();
        IDataResult<CarDetailDto> GetCarDetails(int carId);
        IDataResult<List<CarDetailDto>> GetCarsByBrandAndColor(int brandId, int colorId);

    }   
}
