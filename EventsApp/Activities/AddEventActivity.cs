using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Widget;

namespace EventsApp.Activities
{
    [Activity(Label = "AddEventActivity")]
    public class AddEventActivity : Activity, IOnMapReadyCallback, GoogleMap.IOnMapClickListener
    {
        private GoogleMap GMap;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddEvent);
            SetUpMap();
            SetUpSpinner();
        }

        private void SetUpSpinner()
        {
            Spinner spinner = FindViewById<Spinner>(Resource.Id.eventSpinner);
            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.events, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
        }

        private void SetUpMap()
        {
            if (GMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            this.GMap = googleMap;
            GMap.SetOnMapClickListener(this);
        }

        public void OnMapClick(LatLng point)
        {
            var markerOptions = new MarkerOptions().SetPosition(point);
            GMap.AddMarker(markerOptions);
        }
    }
}