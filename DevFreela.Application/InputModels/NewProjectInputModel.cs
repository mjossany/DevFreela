namespace DevFreela.API.DevFreela.Application.ViewModels;

public class NewProjectInputModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int idClient { get; set; }
    public int IdFreelancer { get; set; }
    public decimal TotalCost { get; set; }
}