
using SModel.UtubeService;
using SModel.NetFlixService;

namespace ServiceDTOs
 { 


public class ServicesDTO
{
public string ServiceId {get; set;} = string.Empty;

public int WeeklyService {get; set;}  

public int MonthlyService {get;set;}

public int YearlyService  {get; set;}

public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public int SubscriptionDurationTracker {get; set;}

public string UserId {get; set;} = string.Empty;
  }

}