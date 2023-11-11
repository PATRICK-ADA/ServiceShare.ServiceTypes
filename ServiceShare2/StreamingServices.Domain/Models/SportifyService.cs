

namespace SModel.SportifyService
{
public class SportifyService
    {

public string SportifyServiceId {get; set;} = Guid.NewGuid().ToString();
public int WeeklyService {get; set;}  = 7;
public int MonthlyService {get;set;} = 30;

public int YearlyService  {get; set;} = 360;

public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public int SubscriptionDurationTracker {get; set;}

public string UserId {get; set;} = string.Empty;


    }
}