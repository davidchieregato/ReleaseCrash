using System;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ReleaseCrash
{
	public partial class TestViewModel: ObservableObject
	{
        [ObservableProperty]
        private string[] _dayNames;

        public TestViewModel()
		{
            DayNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedDayNames;
        }
	}
}

