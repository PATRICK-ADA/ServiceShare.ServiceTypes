using SModel.SportifyService;


namespace Abstraction.ISportifyService
{

public interface ISportifyService
  {


Task<SportifyService> GeatServiceById(string serviceId);
Task<SportifyService> GetServiceByServicePlan(string serviceType);
Task<List<SportifyService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedYearlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedMonthlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedWeeklyServicePlans(int maxNumberOfUsers);

Task<SportifyService> GetYearlyServiceAsync();
Task<SportifyService> GetMonthlyServiceAsync();
Task<SportifyService> GetWeeklyServiceAsync();
 
 }



}