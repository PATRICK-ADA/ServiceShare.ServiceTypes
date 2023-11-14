using SModel.NetFlixService;


namespace Abstraction.INetFlixRepository 
{

public interface INetFlixRepository
  {

Task<NetFlixService> GetServiceById(string serviceId);
Task<NetFlixService?>  GetServiceByServicePlan(string serviceType);
Task<IEnumerable<NetFlixService>> GetAllUserServicePlansByUserId(string UserId);
Task<int>  GetNumberOfUnusedYearlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedMonthlyServicePlans(int maxNumberOfUsers);
Task<int>  GetNumberOfUnusedWeeklyServicePlans(int maxNumberOfUsers);

Task<NetFlixService?>  GetYearlyServiceAsync();

Task<NetFlixService?>  GetMonthlyServiceAsync();

Task<NetFlixService?>  GetWeeklyServiceAsync();
 }
}