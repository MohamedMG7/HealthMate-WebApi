using Microsoft.AspNetCore.Http;

namespace HealthMate.BLL.Manager.MedicalRecordManager{
    public interface IRecordImageManager{
        Task<bool> UploadLabTestImage(string medicalRecordName, IFormFile image, int patientId);
        Task<bool> UploadPrescriptionImage(string medicalRecordName, IFormFile image, int patientId);
        Task<bool> UploadMedicalImage(string medicalImageName, IFormFile image, int patientId, string interpretation);
    }
}