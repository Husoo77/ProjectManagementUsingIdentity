using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagementUsingIdentity.Application.Services.Interface;
using ProjectManagementUsingIdentity.Domain.Entities;
using ProjectManagementUsingIdentity.Infrastructure.Data;

namespace ProjectManagementUsingIdentity.Controllers;
public class ProjectController : Controller
{
    private readonly IProjectService _projectService;
    private readonly ICustomerService _customerService;

    public ProjectController(IProjectService projectService, ICustomerService customerService)
    {
        _projectService = projectService;
        _customerService = customerService;
    }
    public IActionResult Index()
    {
        var projects = _projectService.GetAllProjects();
        ViewBag.Customers = new SelectList(_customerService.GetAllCustomers(), "Id", "Name");
        return View(projects);
    }

    [HttpPost]
    public IActionResult Create(Project obj)
    {
        ModelState.Remove("Customer");
        if (ModelState.IsValid)
        {
            obj.CreatedDate = DateTime.Now;
            _projectService.CreateProject(obj);
            TempData["success"] = "The project has been created successfully.";
            return RedirectToAction(nameof(Index));
        }

        TempData["error"] = "Failed to create the project";
        ViewBag.Customers = new SelectList(_customerService.GetAllCustomers(), "Id", "Name", obj.CustomerId);
        return View(obj);
    }

    [HttpPost]
    public IActionResult Update(Project obj)
    {
        ModelState.Remove("Customer");
        if (ModelState.IsValid && obj.Id > 0)
        {

            _projectService.UpdateProject(obj);
            TempData["success"] = "The project has been updated successfully.";
            return RedirectToAction(nameof(Index));
        }
        return View();
    }
 
    [HttpPost]
    public IActionResult Delete(Project obj)
    {
        bool deleted = _projectService.DeleteProject(obj.Id);
        if (deleted)
        {
            TempData["success"] = "The project has been deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
        else
        {
            TempData["error"] = "Failed to delete the project.";
        }
        return View();
    }
}


