using SModel.SportifyService;


namespace Abstraction.ISportifyService
{

public interface ISportifyService
  {


Task<SportifyService> GeatServiceById(string serviceId);
Task<SportifyService> GetServiceByServicePlan(string serviceType);
Task<List<SportifyService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedServices(int maxNumberOfMonthlyUsers);

 
 }



}