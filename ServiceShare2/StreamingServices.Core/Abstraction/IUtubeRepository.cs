
using SModel.UtubeService;


namespace Abstraction.IUtubeRepository
{
public interface IUtubeRepository

  { 

Task<UtubeService> GetServiceById(string serviceId);
Task<UtubeService> GetServiceByServicePlan(string serviceType);
Task<List<UtubeService>> GetServicesByUserId(string UserId);
Task<int>  GetNumberOfUnusedServices(int maxNumberOfMonthlyUsers);

  }

}