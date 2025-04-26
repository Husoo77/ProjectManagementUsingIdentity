using ProjectManagementUsingIdentity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Application.Services.Interface;
public interface ICustomerService
{
    IEnumerable<Customer> GetAllCustomers();
}
