using SModel.NetFlixService;


namespace Abstraction.INetFlixService
{

public interface INetFlixService
  {

Task<NetFlixService> GetServiceById(string serviceId);
Task<NetFlixService> GetServiceByServicePlan(string serviceType);
Task<List<NetFlixService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedServicePlans (int maxNumberOfUsers);


 }



}