
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
        IDataResult<List<OperationClaim>> GetClaims(int id);
        User GetByMail(string email);
        IDataResult<UserFindeksReturnDto> GetUserFindex(UserFindeksDto userFindeksDto);
        
    }
}