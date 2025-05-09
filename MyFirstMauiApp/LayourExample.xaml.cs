namespace MyFirstMauiApp;

public partial class LayourExample : ContentPage
{
	public LayourExample()
	{
		InitializeComponent();

		VStackLayout.Padding = DeviceInfo.Platform == DevicePlatform.iOS
			? new Thickness(30,10,30,10) : new Thickness(25);
	}
}