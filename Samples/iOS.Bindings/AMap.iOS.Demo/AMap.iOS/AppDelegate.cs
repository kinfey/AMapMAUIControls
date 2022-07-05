
using iOS.AMap._3D;
using iOS.AMap.Foundation;

namespace AMap.iOS;


[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController with a single UILabel
		var vc = new UIViewController ();


        AMapServices.SharedServices.ApiKey = "";
        AMapServices.SharedServices.EnableHTTPS = true;
        MAMapView.UpdatePrivacyShow(AMapPrivacyShowStatus.DidShow, AMapPrivacyInfoStatus.DidContain);
        MAMapView.UpdatePrivacyAgree(AMapPrivacyAgreeStatus.DidAgree);



        MAMapView map = new MAMapView();
        map.Frame = vc.View!.Bounds;
        map.SetShowsUserLocation(true);
        map.SetUserTrackingMode(MAUserTrackingMode.Follow,true);

        

		vc.View!.AddSubview (map);
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}
