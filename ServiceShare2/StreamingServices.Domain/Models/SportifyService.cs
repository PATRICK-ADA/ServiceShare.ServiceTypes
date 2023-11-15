

namespace SModel.SportifyService
{
public class SportifyService
    {

public string SportifyServiceId {get; set;} = Guid.NewGuid().ToString();
public int WeeklyService {get; set;}  = 7;
public int MonthlyService {get;set;} = 30;

public int YearlyService  {get; set;} = 360;


public int SportifyYearlyUsersCappacity {get; set;}

public int SportifyMonthlyUsersCappacity {get; set;}

public int SportifyWeeklyUsersCappacity {get; set;}

public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public string UserId {get; set;} = string.Empty;

    }
}