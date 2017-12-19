using System;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using System.Net;
using System.IO;
using Android.Widget;
using Android.Media;

namespace broadcast_example
{
    [Service]
    public class Services : Service
    {
        const int NotificationId = 9000;
        private Timer timer;
        private string url = "http://cr.globalpueblo.com/alarmserviceapi/api/notification/2";

        public override void OnCreate()
        {
            base.OnCreate();
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            Log.Debug("ss", "My BG serivce has started successfully.");
            DebugMyBgService();
            // getNotification();
            return StartCommandResult.Sticky;
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public void DebugMyBgService()
        {
                timer = new Timer((o) =>
                {
                    Log.Debug("ss", getNotification());
                }, null, 0, 5000);   
        }

        public string getNotification()
        {
            var pathToPushSound = "android.resource://" + this.ApplicationContext.PackageName + "/raw/pushalert";
            var soundUri = Android.Net.Uri.Parse(pathToPushSound);
            var apiRequest = WebRequest.CreateHttp(url);
                apiRequest.Method = "GET";
                var response = (HttpWebResponse)apiRequest.GetResponse();
                var retval = new StreamReader(response.GetResponseStream()).ReadToEnd();
                //if (String.IsNullOrEmpty(retval) || retval == "null")
                //{
                //    Notification.Builder notificationBuilder = new Notification.Builder(this)
                //    .SetSmallIcon(Resource.Drawable.Icon)
                //    .SetContentTitle("No data in the database.")
                //    .SetContentText("hey there is no data present in the database.");
                //    var notificationManager = (NotificationManager)GetSystemService(NotificationService);
                //    notificationManager.Notify(NotificationId, notificationBuilder.Build());
                //    return "No data in the database";
                //}
                if (!String.IsNullOrEmpty(retval) && retval != "null")
                {
                    var notificationBuilder = new Notification.Builder(this)
                    .SetSmallIcon(Resource.Drawable.Icon)
                    .SetSound(RingtoneManager.GetDefaultUri(RingtoneType.All))
                    .SetContentTitle("Hey! Client is looking for you.")
                    .SetContentText("Hey Come back client needs you urgently");
                    var notificationManager = (NotificationManager)GetSystemService(NotificationService);
                    StartForeground(NotificationId, notificationBuilder.Build());
                    //StartForeground(NotificationId, notificationBuilder);
                }           
            return "notification method";
        }
    }
}
//RingtoneManager.GetDefaultUri(RingtoneType.Notification