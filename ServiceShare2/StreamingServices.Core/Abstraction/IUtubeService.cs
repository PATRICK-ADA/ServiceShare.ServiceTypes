
using System.Runtime.Serialization;
using SModel.UtubeService;

namespace Abstraction.IUtubeService
{ 
public interface IUtubeService
  {
Task<UtubeService> GetServiceById(string serviceId);
Task<UtubeService> GetServiceByServicePlan(string serviceType);
Task<List<UtubeService>> GetServicesByUserId(string UserId);
  }

}
