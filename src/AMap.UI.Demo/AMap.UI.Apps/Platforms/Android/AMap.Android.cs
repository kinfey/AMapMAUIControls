using System;
using Android.OS;
using Java.Interop;
using Microsoft.Maui.Handlers;
using Com.Amap.Api.Maps;
using Com.Amap.Api.Location;

namespace AMap.UI.Apps
{
    public partial class AMapHandler : ViewHandler<IAMap, MapView>
    {
        private AMapHelper _mapHelper;
        private MapView mapView;
        internal static Bundle Bundle { get; set; }

        public AMapHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }


        protected override MapView CreatePlatformView()
        {


            //AMapLocationClient.UpdatePrivacyAgree(Context, true);
            //AMapLocationClient.UpdatePrivacyShow(Context, true, true);

            //mapView.OnCreate(Bundle);
            mapView = new Com.Amap.Api.Maps.MapView(Context);
            //mapView.OnCreate(savedInstanceState);
            //SetContentView(mapView);
            return mapView;
        }

        protected override void ConnectHandler(MapView platformView)
        {
            base.ConnectHandler(platformView);


            AMapLocationClient.UpdatePrivacyAgree(Context, true);
            AMapLocationClient.UpdatePrivacyShow(Context, true, true);

            _mapHelper = new AMapHelper(Bundle, platformView);
            //_mapHelper.MapIsReady += _mapHelper_MapIsReady;
            mapView = _mapHelper.CallCreateMap();
        }
    }



    class AMapHelper : Java.Lang.Object
    {

        private Bundle _bundle;
        private MapView _mapView;

        public event EventHandler MapIsReady;

        public MapView Map { get; set; }

        public AMapHelper(Bundle bundle, MapView mapView)
        {
            _bundle = bundle;
            _mapView = mapView;
        }

        public MapView CallCreateMap()
        {
            
            //AMapLocationClient.UpdatePrivacyAgree(Context, true);
            //AMapLocationClient.UpdatePrivacyShow(Context, true, true);
            _mapView.OnCreate(_bundle);
            return _mapView;
            //_mapView.GetMapAsync(this);
        }


    }

}