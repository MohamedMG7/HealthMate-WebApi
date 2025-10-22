using HealthMate.BLL.Manager.MachineLearningManager;
using HealthMate.DAL.DTO.MachineLearningDto;
using HealthMate.DAL.Reposatiries.ObservationRepos;
using Moq;
using Xunit;

namespace HealthMate.Tests.BLL.Manager
{
    public class MachineLearningManagerTests
    {
        private readonly Mock<IObservationRepo> _mockObservationRepo;
        private readonly MachineLearningManager _manager;

        public MachineLearningManagerTests()
        {
            _mockObservationRepo = new Mock<IObservationRepo>();
            _manager = new MachineLearningManager(_mockObservationRepo.Object);
        }

        //[Fact]
        //public async Task CheckAnimea_ReturnsExpectedResult()
        //{
            // Arrange
        //    var patientId = 1;
        //    var testData = new CBCTestData
        //    {
        //        Hemoglobin = 12.5,
        //        RedBloodCells = 4.5,
        //        PackedCellVolume = 38,
        //        MeanCorpuscularHemoglobin = 27,
         //       MeanCorpuscularHemoglobinConcentration = 33
        //    };

        //    _mockObservationRepo.Setup(repo => repo.GetRecentCBCTestForML(patientId))
        //        .ReturnsAsync(testData);

            // Act
        //    var result = await _manager.CheckAnimea(patientId);

            // Assert
        //    Assert.NotNull(result);
        //    Assert.Equal(testData, result.animeaData);
        //    Assert.False(string.IsNullOrEmpty(result.ErrorMessage));
        //}

        // [Fact]
        // public async Task CheckAnimea_HandlesException()
        // {
        //     // Arrange
        //     var patientId = 1;
        //     _mockObservationRepo.Setup(repo => repo.GetRecentCBCTestForML(patientId))
        //         .ThrowsAsync(new Exception("Test exception"));

        //     // Act
        //     var result = await _manager.CheckAnimea(patientId);

        //     // Assert
        //     Assert.NotNull(result);
        //     Assert.False(result.IsNormal);
        //     Assert.Contains("Test exception", result.ErrorMessage);
        // }
    }

    public class MachineLearningHelper{
        
        [Fact]
        public async Task CalculateDiabetesPedigreeFunction(){
            // Arrange
            // Act
            // Assert
            
        }
    }
}
