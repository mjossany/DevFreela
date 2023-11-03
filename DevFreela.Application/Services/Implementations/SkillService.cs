using DevFreela.API.DevFreela.Application.Services.Interfaces;
using DevFreela.API.DevFreela.Application.ViewModels;
using DevFreela.Infrasctructure.Persistence;

namespace DevFreela.API.DevFreela.Application.Services.Implementations;

public class SkillService : ISkillService
{
    private readonly DevFreelaDbContext _dbContext;

    public SkillService(DevFreelaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<SkillViewModel> GetAll()
    {
        var skills = _dbContext.Skills;

        var skillsViewModel = skills
            .Select(s => new SkillViewModel(s.Id, s.Description))
            .ToList();

        return skillsViewModel;
    }
}