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

return await _context.Netflix.FirstOrDefaultAsync(s => s.ServiceId == serviceID);

}


public async Task<int> GetServiceByServicePlan()
{

var Result =_context.Netflix.FirstOrDefaultAsync(i => i.ServiceType == serviceType)

}

public async Task<List<NetFlixService>> GetAllUserServicePlansByUserId(string UserId)
{



}



public async Task<int>  GetNumberOfUnusedYearlyServicePlans(int netFlixYearlyUsersCappacity)
{

var unusedPlans = _context.Netflix.Where(i => i.NetFlixYearlyUsersCappacity > 0 && i.PlanType == "Yearly").ToList();

}




}


}