using Abstraction.INetFlixRepository;
using Data.ApplicationContext;
using SModel.NetFlixService;


namespace Infrastructure.NetFlixRepository
{

public class NetFlixRepository : INetFlixRepository
{

private readonly ApplicationContext _context;


public NetFlixRepository(ApplicationContext context)
{

_context = context;

}


public async Task<NetFlixService> GetServiceById(string serviceId)
{

return await _context.Netflix.FirstOrDefaultAsync(s => s.ServiceId == ServiceID);

}


public async Task<NetFlixService> GetServiceByServicePlan(string serviceType)
{



}

public async Task<List<NetFlixService>> GetAllUserServicePlansByUserId(string UserId)
{



}

public async Task<int>  GetNumberOfUnusedServicePlans(int maxNumberOfUsers)
{
var ServicePlans = _context.Netflix.Where(i => i == WeeklyService && i == MonthlyService && i == YearlyService ).Select(i => i).ToList();



}




}


}