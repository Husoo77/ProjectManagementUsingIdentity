using ProjectManagementUsingIdentity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Application.Services.Interface;
public interface IProjectService
{
    IEnumerable<Project> GetAllProjects();
    Project GetProjectById(int id);
    void CreateProject(Project project);
    void UpdateProject(Project project);
    bool DeleteProject(int id);
}
