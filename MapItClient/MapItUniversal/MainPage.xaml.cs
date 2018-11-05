using System;
using Windows.UI.Xaml.Controls;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MaptIt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		Geolocator geolocator;
		Geoposition geoposition;

		public MainPage()
		{
			this.InitializeComponent();
			geolocator = new Geolocator();
			geolocator.DesiredAccuracyInMeters = 5;
			geolocator.ReportInterval = 0;

			GetLocation.Click += async (sender, e) =>
				{
					geoposition = await geolocator.GetGeopositionAsync();
					string latitude = geoposition.Coordinate.Latitude.ToString("0.0000000000");
					string Longitude = geoposition.Coordinate.Longitude.ToString("0.0000000000");
					string Accuracy = geoposition.Coordinate.Accuracy.ToString("0.0000000000");

					location.Text = "Latitude = " + latitude + "\nLongitude = " + Longitude;
				};


		}
	}
}
