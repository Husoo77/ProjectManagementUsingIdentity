using ProjectManagementUsingIdentity.Application.Common.Interfaces;
using ProjectManagementUsingIdentity.Domain.Entities;
using ProjectManagementUsingIdentity.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Infrastructure.Repository;
public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context) : base(context)
    {

        _context = context;
    }

}