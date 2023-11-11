
using System.Runtime.Serialization;
using SModel;

namespace Abstraction.IUtubeService
{ 
public interface IUtubeService
  {

Task<Services> GetServiceById(string serviceId);
Task<Services> GetServiceByServiceType(string serviceType);
Task<List<Services>> GetServicesByUserId(string UserId);

  }

}