using SModel.SportifyService;


namespace Abstraction.ISportifyRepository
{

public interface ISportifyRepository
  {

Task<SportifyService> GetServiceById(string serviceId);
Task<SportifyService> GetServiceByServicePlan(string serviceType);
Task<List<SportifyService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedServices(int maxNumberOfUsers);


 }



}