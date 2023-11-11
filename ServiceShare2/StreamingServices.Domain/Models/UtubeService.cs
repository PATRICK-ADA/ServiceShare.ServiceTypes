
using System.Dynamic;

namespace SModel.UtubeService
{
public class UtubeService
    {

public string UtubeServiceId {get; set;} = Guid.NewGuid().ToString();
public int WeeklyService {get; set;}  = 7;
public int MonthlyService {get;set;} = 30;

public int YearlyService  {get; set;} = 360;

public int UtubeYearlyUsersCappacity {get; set;}
public int UtubeMonthlyUsersCappacity {get; set;}

public int UtubeWeeklyUsersCappacity {get; set;}

public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public string UserId {get; set;} = string.Empty;

   }

}