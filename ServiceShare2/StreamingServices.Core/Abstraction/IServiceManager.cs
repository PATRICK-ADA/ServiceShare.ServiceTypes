
using System.Runtime.Serialization;
using SModel;

namespace IServiceMan
{
public interface IServiceManager
{

Task<Services> GetServiceById(string serviceId);
Task<Services> GetServiceByServiceType(string serviceType);
Task<List<Services>> GetServicesByUserId(string UserId);

}

}