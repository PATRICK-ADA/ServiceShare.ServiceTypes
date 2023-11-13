using SModel.SportifyService;


namespace Abstraction.ISportifyRepository
{

public interface ISportifyRepository
  {


Task<SportifyService> GetServiceById(string serviceId);
Task<SportifyService> GetServiceByServicePlan(string serviceType);
Task<IEnumerable<SportifyService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedYearlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedMonthlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedWeeklyServicePlans(int maxNumberOfUsers);


 }



}