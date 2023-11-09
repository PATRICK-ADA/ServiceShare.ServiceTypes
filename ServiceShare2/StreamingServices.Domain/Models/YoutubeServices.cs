
namespace SModel
 { 
public class YoutubeServices
 {
public string ServiceId {get; set;} = Guid.NewGuid().ToString();
public string SubsType {get; set;}  = null!;

public string UserId {get; set;} = string.Empty;

public int SubscriptionDurationTracker {get; set;}

  }

}