using System;
using System.Collections.Generic;
using DevFreela.Core.Entities;

namespace DevFreela.Infrasctructure.Persistence;

public class DevFreelaDbContext
{
    public DevFreelaDbContext()
    {
        Projects = new List<Project>
        {
            new Project("Meu projeto ASPNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000),
            new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2", 1, 1, 20000),
            new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3", 1, 1, 30000)
        };
        Users = new List<User>()
        {
            new User("Luis Felipe", "luisdev@luisdev.com.br", new DateTime(1992, 1, 1)),
            new User("Robert C Martin", "robert@robertdev.com.br", new DateTime(1993, 1, 1)),
            new User("Anderson", "anderson@andersondev.com.br", new DateTime(1994, 1, 1)),
        };
        Skills = new List<Skill>()
        {
            new Skill(".Net Core"),
            new Skill("C#"),
            new Skill("SQL")
        };
    }
    
    public List<Project> Projects { get; set; }
    public List<User> Users { get; set; }
    public List<Skill> Skills { get; set; }
    public List<ProjectComment> ProjectComments { get; set; }
}