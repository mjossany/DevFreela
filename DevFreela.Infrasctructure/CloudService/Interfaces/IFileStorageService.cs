namespace DevFreela.Infrasctructure.CloudService.Interfaces;

public interface IFileStorageService
{
    void UploadFile(byte[] bytes, string fileName);
}