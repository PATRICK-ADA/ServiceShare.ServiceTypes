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

 
 public async Task<NetFlixService?> GetYearlyServiceAsync()
    {
        
        return await _context.Netflix.FirstOrDefaultAsync(i => i.YearlyService == 360);
    }

    
    public async Task<NetFlixService?> GetMonthlyServiceAsync()
    {
         return await _context.Netflix.FirstOrDefaultAsync(i => i.MonthlyService == 30);
    }

    public async Task<NetFlixService?> GetWeeklyServiceAsync()
    {
         return await _context.Netflix.FirstOrDefaultAsync(i => i.WeeklyService == 7);
    }



public async Task<NetFlixService?> GetServiceByServicePlan(string servicePlan)
{
 return servicePlan switch
    {
        "YearlyService" => await _context.Netflix.YearlyService(),
        "MonthlyService" => await _context.Netflix.MonthlyService(),
        "WeeklyService" => await _context.Netflix.WeeklyService()
    };
}

public async Task<IEnumerable<NetFlixService>> GetAllUserServicePlansByUserId(string UserId)
{



}



public async Task<int>  GetNumberOfUnusedYearlyServicePlans(int netFlixYearlyUsersCappacity)
{

var unusedPlans = _context.Netflix.Where(i => i.NetFlixYearlyUsersCappacity > 0 && i.PlanType == "Yearly").ToList();

}




}


}