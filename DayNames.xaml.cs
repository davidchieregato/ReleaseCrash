namespace ReleaseCrash;

public partial class DayNames : ContentPage
{
	TestViewModel vm;
	public DayNames()
	{
		InitializeComponent();
		vm = new TestViewModel();
		BindingContext = vm;
	}
}
