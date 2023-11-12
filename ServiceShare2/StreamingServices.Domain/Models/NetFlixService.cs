

namespace SModel.NetFlixService
 { 

public class NetFlixService
{
public string NetFlixServiceId {get; set;} = Guid.NewGuid().ToString();

public int WeeklyService {get; set;}  = 7;
public int MonthlyService {get;set;} = 30;

public int YearlyService  {get; set;} = 360;

public int NetFlixYearlyUsersCappacity {get; set;}

public int NetFlixMonthlyUsersCappacity {get; set;}

public int NetFlixWeeklyUsersCappacity {get; set;}

public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public string UserId {get; set;} = string.Empty;

  }

}