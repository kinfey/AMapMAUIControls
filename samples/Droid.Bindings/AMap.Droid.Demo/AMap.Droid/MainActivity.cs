using Com.Amap.Api.Maps;
using Com.Amap.Api.Location;

namespace AMap.Droid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);


        AMapLocationClient.UpdatePrivacyAgree(this, true);
        AMapLocationClient.UpdatePrivacyShow(this, true, true);


        MapView mapView  = new Com.Amap.Api.Maps.MapView(this);
        mapView.OnCreate(savedInstanceState);
        SetContentView(mapView);
    }
}