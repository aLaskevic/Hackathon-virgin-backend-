using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers;

[ApiController]
[EnableCors("CorsPolicy")]
public class ProjectController : Controller
{
    ProjectRepository _repository;

    public ProjectController(ProjectRepository projectRepository)
    {
        _repository = projectRepository;
    }
    
    [HttpGet]
    [Route("/api/projects")]
    public IActionResult GetProjects()
    {
        return new OkObjectResult(_repository.GetProjects());
    }
    
    [HttpGet]
    [Route("/api/projects/{projectId}")]
    public IActionResult GetProjects(int projectId)
    {
        return new OkObjectResult(_repository.GetProjects()[projectId]);
    }
    
    [HttpPost]
    [Route("/api/projects")]
    public IActionResult AddProject(Project project)
    {
        _repository.AddProjects(project);
        return Ok();
    }

    [HttpPost]
    [Route("/api/projects/{projectId}/callsToAction")]
    public IActionResult AddReward(int projectId, CallToAction callToAction)
    {
        var project = _repository.Projects.Where(p => p.Id == projectId).FirstOrDefault();
        project.CallToActions.Add(callToAction);
        return Ok();
    }
    


}