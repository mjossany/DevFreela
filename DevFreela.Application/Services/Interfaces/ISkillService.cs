using DevFreela.API.DevFreela.Application.ViewModels;

namespace DevFreela.API.DevFreela.Application.Services.Interfaces;

public interface ISkillService
{
    List<SkillViewModel> GetAll();
}