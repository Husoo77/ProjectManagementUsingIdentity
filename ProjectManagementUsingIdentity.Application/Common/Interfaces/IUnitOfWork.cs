using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Application.Common.Interfaces;
public interface IUnitOfWork
{
    IProjectRepository Project { get; }
    ICustomerRepository Customer { get; }
    void Save();
}
