using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars 
                             join color in context.Colors
                                on car.ColorId equals color.ColorId

                             join carImage in context.CarImages
                                on car.CarId equals carImage.CarId

                             join brand in context.Brands
                                on car.BrandId equals brand.BrandId

                             select new CarDetailDto()
                             {
                                 CarId = car.CarId,
                                 Description = car.Description,
                                 BrandId = brand.BrandId,
                                 BrandName = brand.BrandName,
                                 ImagePath = carImage.ImagePath,
                                 ColorId = color.ColorId,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 FindeksScore=car.FindeksScore
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public CarDetailDto GetCarDetails(int carId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars.Where(c => c.CarId == carId)

                             join color in context.Colors
                             on car.ColorId equals color.ColorId

                             join carImage in context.CarImages
                               on car.CarId equals carImage.CarId


                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new CarDetailDto()
                             {
                                 CarId = car.CarId,
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 ImagePath= carImage.ImagePath,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 FindeksScore=car.FindeksScore


                             };

                return result.SingleOrDefault();
            }
        }

   
    }
}
