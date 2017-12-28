using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using EventsApp.Activities;
using EventsApp.Helpers;
using EventsApp.Models;

namespace EventsApp
{
    [Activity(Label = "EventsApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button addEventButton = FindViewById<Button>(Resource.Id.AddEvent);
            addEventButton.Click += delegate
            {
                Intent addEventIntent = new Intent(this, typeof(AddEventActivity));
                StartActivity(addEventIntent);
            };

            EventHelper helper = new EventHelper();

            helper.SaveTodoItemAsync(new Event {Date = DateTime.Now}, true);
        }


    }
}

