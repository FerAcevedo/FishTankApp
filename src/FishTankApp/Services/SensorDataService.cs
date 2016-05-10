using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishTankApp.Models;

namespace FishTankApp.Services
{
    public class SensorDataService: ISensorDataService
    {
        private readonly Random random = new Random();
        private IEnumerable<IntHistoryModel> waterTemperatureHistory;
        private IEnumerable<IntHistoryModel> fishMotionHistory;
        private IEnumerable<IntHistoryModel> waterOpacityHistory;
        private IEnumerable<IntHistoryModel> lightOpacityHistory;

        public IntHistoryModel GetWaterTemperatureFahrenheit()
        {
            return GetWaterTemperatureFahrenheitHistory().Last();
        }

        private IEnumerable<IntHistoryModel> GetWaterTemperatureFahrenheitHistory()
        {
            return waterTemperatureHistory ?? (waterTemperatureHistory = GetHistory(70, 90));
        }

        #region Water Temperature
        #endregion

        #region Fish Motion
        public IntHistoryModel GetFishMotionPercentage()
        {
            return GetFishMotionPercentageHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
        {
            return fishMotionHistory ?? (fishMotionHistory = GetHistory(0, 100));
        }
        #endregion

        #region Water Opacity
        public IntHistoryModel GetWaterOpacityPercentage()
        {
            return GetWaterOpacityPercentageHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
        {
            return waterOpacityHistory ?? (waterOpacityHistory = GetHistory(0, 100));
        }
        #endregion

        #region Light Intensity
        public IntHistoryModel GetLightIntensityLumens()
        {
            return GetLightIntensityLumensHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory()
        {
            return lightOpacityHistory ?? (lightOpacityHistory = GetHistory(0, 5000));
        }
        #endregion

        #region Random History
        private IEnumerable<IntHistoryModel> GetHistory(int min, int max)
        {
            var result = new List<IntHistoryModel>();
            for (var i = -10; i < 1; i++)
            {
                result.Add(new IntHistoryModel(DateTime.Now.AddHours(i), random.Next(min, max)));
            }
            return result;
        } 
        #endregion
    }
}
