using System;
using System.Collections.Generic;
using DevFreela.API.DevFreela.Application.Services.Interfaces;
using DevFreela.API.DevFreela.Application.ViewModels;

namespace DevFreela.API.DevFreela.Application.Services.Implementations;

public class ProjectService : IProjectService
{
    public List<ProjectViewModel> GetAll(string query)
    {
        throw new NotImplementedException();
    }

    public ProjectDetailsViewModel GetById(int id)
    {
        throw new NotImplementedException();
    }

    public int Create(NewProjectInputModel inputModel)
    {
        throw new NotImplementedException();
    }

    public void Update(UpdateProjectInputModel inputModel)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void CreateComment(CreateCommentInputModel inputModel)
    {
        throw new NotImplementedException();
    }

    public void Start(int id)
    {
        throw new NotImplementedException();
    }

    public void Finish(int id)
    {
        throw new NotImplementedException();
    }
}