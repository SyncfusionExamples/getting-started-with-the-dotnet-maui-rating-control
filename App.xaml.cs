namespace MAUIExample;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTIxOTIzOEAzMjMwMmUzNDJlMzBBOXdpRFlrQThlenBkYjFON1N2cEFOSzhSeFVNb1k0ZUtsZ0RiWG1LRXFRPQ==");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
