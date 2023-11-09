namespace ReleaseCrash;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("daypage", typeof(DayNames));
    }
}

