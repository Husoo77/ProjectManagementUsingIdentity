using Microsoft.AspNetCore.Hosting;
using ProjectManagementUsingIdentity.Application.Common.Interfaces;
using ProjectManagementUsingIdentity.Application.Services.Interface;
using ProjectManagementUsingIdentity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Application.Services.Implementation;
public class ProjectService : IProjectService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProjectService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public void CreateProject(Project project)
    {
        _unitOfWork.Project.Add(project);
        _unitOfWork.Save();
    }

    public IEnumerable<Project> GetAllProjects()
    {
        return _unitOfWork.Project.GetAll(includeProperties: "Customer");
    }

    public Project GetProjectById(int id)
    {
        return _unitOfWork.Project.Get(u => u.Id == id, includeProperties: "Customer");
    }

    public void UpdateProject(Project project)
    {
        _unitOfWork.Project.Update(project);
        _unitOfWork.Save();
    }
    public bool DeleteProject(int id)
    {
        try
        {
            Project? objFromDb = _unitOfWork.Project.Get(u => u.Id == id);
            if (objFromDb is not null)
            {
                _unitOfWork.Project.Remove(objFromDb);
                _unitOfWork.Save();

            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

}
