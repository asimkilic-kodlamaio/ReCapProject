using System.Collections.Generic;
using Core.Utilities.Results;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    { 
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
} 