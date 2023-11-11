
namespace SModel
 { 
public class Services
{
public string ServiceId {get; set;} = Guid.NewGuid().ToString();

public string SubsType {get; set;}  = null!;

public string UserId {get; set;} = string.Empty;
public DateTime SubscriptionTime {get; set;} = DateTime.Now;

public int SubscriptionDurationTracker {get; set;}

  }

}