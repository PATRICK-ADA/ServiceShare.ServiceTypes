
using System.Runtime.Serialization;
using SModel.UtubeService;

namespace Abstraction.IUtubeService
{ 
public interface IUtubeService
  {
Task<UtubeService> GetServiceById(string serviceId);
Task<UtubeService> GetServiceByServicePlan(string serviceType);
Task<List<UtubeService>> GetServicesByUserId(string UserId);
Task<int>  GetNumberOfUnusedYearlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedMonthlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedWeeklyServicePlans(int maxNumberOfUsers);

  }

}
