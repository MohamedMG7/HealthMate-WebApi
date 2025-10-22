using Microsoft.AspNetCore.Mvc;

namespace HealthMate.BLL.Manager.DocumentManager{
    public interface IDocumentManager{
        Task<FileResult> GetFileAsync(string filePath);
    }
}