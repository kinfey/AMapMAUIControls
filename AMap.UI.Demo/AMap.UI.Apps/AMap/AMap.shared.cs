using System;
using System.Threading.Tasks;
using Microsoft.Maui.Handlers;

namespace AMap.UI.Apps
{

    public interface IAMap : IView
    {
    }


    public class AMap : View, IAMap
    {

    }


    partial class AMapHandler
    {
        public static IPropertyMapper<AMap, AMapHandler> MapMapper = new PropertyMapper<AMap, AMapHandler>(ViewHandler.ViewMapper)
        { };

        public AMapHandler() : base(MapMapper)
        { }
    }

}

