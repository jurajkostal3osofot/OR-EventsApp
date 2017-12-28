using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EventsApp.Models;
using Newtonsoft.Json;

namespace EventsApp.Helpers
{
    class EventHelper
    {
        private HttpClient client;
        public EventHelper()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }
        public async Task SaveTodoItemAsync(Event newEvent, bool isNewItem = false)
        {
            // RestUrl = http://developer.xamarin.com:8081/api/todoitems/
            var uri = new Uri(string.Format(Constants.eventsUrl, string.Empty));

               
            var json = JsonConvert.SerializeObject(newEvent);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await client.PostAsync(uri, content);
            }
           

            if (response.IsSuccessStatusCode)
            {
             

            }
           
        }
    }
}