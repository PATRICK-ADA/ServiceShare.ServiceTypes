
using SModel.UtubeService;


namespace Abstraction.IUtubeRepository
{
public interface IUtubeRepository

  { 

Task<UtubeService> GetServiceById(string serviceId);
Task<UtubeService> GetServiceByServicePlan(string serviceType);
Task<IEnumerable<UtubeService>> GetServicesByUserId(string UserId);
Task<int>  GetNumberOfUnusedYearlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedMonthlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedWeeklyServicePlans(int maxNumberOfUsers);

  }

}