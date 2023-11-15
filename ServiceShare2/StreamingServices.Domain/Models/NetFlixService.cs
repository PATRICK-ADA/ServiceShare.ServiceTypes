

namespace SModel.NetFlixService
 { 

public class NetFlixService
{

public string NetFlixServiceId {get; set;} = Guid.NewGuid().ToString();

public int YearlyService  {get; set;} = 360;
public int MonthlyService {get;set;} = 30;
public int WeeklyService {get; set;}  = 7;

public int NumberOfUsersRegisteredForAServicePlan{get; set;}

public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public string UserId {get; set;} = string.Empty;

  }

}