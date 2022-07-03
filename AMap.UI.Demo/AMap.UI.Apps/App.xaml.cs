namespace AMap.UI.Apps;
using Microsoft.Maui.Platform;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

	   MainPage = new MapsPage();
	}
}


public class MapsPage : ContentPage
{
	public MapsPage()
	{

	  Content = new AMap();

    }
}
