using System;
using System.Collections.Generic;
using DevFreela.API.DevFreela.Application.Services.Interfaces;
using DevFreela.API.DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrasctructure.Persistence;

namespace DevFreela.API.DevFreela.Application.Services.Implementations;

public class ProjectService : IProjectService
{
    private readonly DevFreelaDbContext _dbContext;

    public ProjectService(DevFreelaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public int Create(NewProjectInputModel inputModel)
    {
        var project = new Project(inputModel.Title, inputModel.Description, inputModel.idClient,
            inputModel.IdFreelancer, inputModel.TotalCost);
        
        _dbContext.Projects.Add(project);

        return project.Id;
    }
    
    public void CreateComment(CreateCommentInputModel inputModel)
    {
        var comment = new ProjectComment(inputModel.Content, inputModel.IdUser, inputModel.IdProject);
        
        _dbContext.ProjectComments.Add(comment);
    }
    
    public void Delete(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
        
        project.Cancel();
    }
    
    public List<ProjectViewModel> GetAll(string query)
    {
        var projects = _dbContext.Projects;

        var projectsViewModel = projects
            .Select(p => new ProjectViewModel(p.Title, p.CreatedAt))
            .ToList();

        return projectsViewModel;
    }

    public ProjectDetailsViewModel GetById(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

        var projectDetailsViewModel = new ProjectDetailsViewModel(
            project.Id, project.Title, project.Description, project.TotalCost, project.StartedAt, project.FinishedAt
            );

        return projectDetailsViewModel;
    }


    public void Update(UpdateProjectInputModel inputModel)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == inputModel.Id);

        project.Update(inputModel.Title, inputModel.Description, inputModel.TotalCost);
    }

    public void Start(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

        project.Start();
    }

    public void Finish(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

        project.Finish();
    }
}