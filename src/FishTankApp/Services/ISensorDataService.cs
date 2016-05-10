using System.Collections.Generic;
using FishTankApp.Models;

namespace FishTankApp.Services
{
    public interface ISensorDataService
    {
        IntHistoryModel GetFishMotionPercentage();
        IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory();
        IntHistoryModel GetLightIntensityLumens();
        IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory();
        IntHistoryModel GetWaterOpacityPercentage();
        IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory();
        IntHistoryModel GetWaterTemperatureFahrenheit();
    }
}