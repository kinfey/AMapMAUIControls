using System;
using System.Threading.Tasks;
using Foundation;
using Microsoft.Maui.Graphics.Platform;
using ObjCRuntime;
using UIKit;

using AMapSDKKit;
using MAMapKit;
using Microsoft.Maui.Handlers;

namespace AMap.UI.Apps
{
    public partial class AMapHandler : ViewHandler<IAMap, MAMapView>
    {
        public AMapHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override MAMapView CreatePlatformView()
        {
            MAMapView.UpdatePrivacyShow(AMapPrivacyShowStatus.DidShow, AMapPrivacyInfoStatus.DidContain);
            MAMapView.UpdatePrivacyAgree(AMapPrivacyAgreeStatus.DidAgree);


            AMapServices.SharedServices.ApiKey = "";
            AMapServices.SharedServices.EnableHTTPS = true;


            MAMapView map = new MAMapView();
            map.SetShowsUserLocation(true);
            map.SetUserTrackingMode(MAUserTrackingMode.Follow);

            return map;
        }

        protected override void ConnectHandler(MAMapView PlatformView)
        { }

        protected override void DisconnectHandler(MAMapView PlatformView)
        {
            // Clean-up the native view to reduce memory leaks and memory usage
            if (PlatformView.Delegate != null)
            {
                PlatformView.Delegate.Dispose();
                PlatformView.Delegate = null;
            }

            PlatformView.RemoveFromSuperview();
        }
    }


}