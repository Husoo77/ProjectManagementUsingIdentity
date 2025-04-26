using ProjectManagementUsingIdentity.Application.Common.Interfaces;
using ProjectManagementUsingIdentity.Domain.Entities;
using ProjectManagementUsingIdentity.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Infrastructure.Repository;
public class ProjectRepository : Repository<Project>, IProjectRepository
{
    private readonly ApplicationDbContext _context;

    public ProjectRepository(ApplicationDbContext context) : base(context)
    {
        
        _context = context;
    }
    public void Update(Project entity)
    {
        _context.Projects.Update(entity);
    }
}
