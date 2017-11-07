using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyInsights;
using System.Threading.Tasks;

namespace TinyInsights.Firebase.iOS
{
    public class TinyInsightsFirebaseProvider : ITinyInsights
    {
        public Task TrackErrorAsync(Exception ex)
        {
            throw new NotImplementedException();
        }

        public Task TrackEventAsync(string eventName)
        {
            throw new NotImplementedException();
        }

        public Task TrackEventAsync(string eventName, Dictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        public Task TrackPageViewAsync(string viewname)
        {
            throw new NotImplementedException();
        }

        public Task TrackPageViewAsync(string viewName, Dictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }
    }
}
