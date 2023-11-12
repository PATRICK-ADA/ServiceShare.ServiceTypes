using SModel.NetFlixService;


namespace Abstraction.INetFlixRepository 
{

public interface INetFlixRepository
  {

Task<NetFlixService> GetServiceById(string serviceId);
Task<NetFlixService> GetServiceByServicePlan(string serviceType);
Task<List<NetFlixService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedServicePlans(int maxNumberOfUsers);


 }



}