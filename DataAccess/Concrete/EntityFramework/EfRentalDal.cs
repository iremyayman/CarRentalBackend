using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq; 

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.CarId

                             join user in context.Users
                             on rental.UserId equals user.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = rental.RentalId,
                                 CarId = rental.CarId,
                                 BrandName = brand.BrandName,
                                 Description=car.Description,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.ToList();
            }
        }

        public RentalDetailDto  GetRentalDetailsById(int rentalId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rental in context.Rentals.Where(r=>r.RentalId==rentalId)
                             join car in context.Cars
                             on rental.CarId equals car.CarId

                             join user in context.Users
                             on rental.UserId equals user.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = rental.RentalId,
                                 CarId = rental.CarId,
                                 BrandName = brand.BrandName,
                                 Description = car.Description,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.SingleOrDefault();
            }
        }
        public List<RentalDetailDto> GetRentalDetailsByUser(int userId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rental in context.Rentals.Where(r => r.UserId == userId)
                             join car in context.Cars
                             on rental.CarId equals car.CarId

                             join user in context.Users
                             on rental.UserId equals user.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = rental.RentalId,
                                 CarId = rental.CarId,
                                 BrandName = brand.BrandName,
                                 Description = car.Description,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
