using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetByCustomerId(int customerId);
        IDataResult<User> GetByUserId(int userId);
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);       
        IDataResult<User> GetByMail(string email);

    }
}
