using DevFreela.API.DevFreela.Application.ViewModels;

namespace DevFreela.API.DevFreela.Application.Services.Interfaces;

public interface iUserService
{
    UserViewModel GetUser(int id);
    int Create(CreateUserInputModel inputModel);
}