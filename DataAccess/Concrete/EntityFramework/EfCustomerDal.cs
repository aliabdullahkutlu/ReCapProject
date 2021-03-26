using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapProjectContext>, ICustomerDal
    {

        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result =
                    from u in context.Users
                    join c in context.Customers on u.UserId equals c.UserId
                    select new CustomerDetailDto()
                    {
                        CustomerName = u.FirstName,
                        CustomerSurname = u.LastName,
                        CustomerCompany = c.CompanyName,
                    };
                return result.ToList();
            }
        }

    }
}
