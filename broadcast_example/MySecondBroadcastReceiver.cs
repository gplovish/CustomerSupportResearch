using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace broadcast_example
{
    [BroadcastReceiver(Enabled = true, Exported = true) ]
    [IntentFilter(new string[] { "android.intent.action.BOOT_COMPLETED" })]
    public class MySecondBroadcastReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "Received Intent", ToastLength.Short).Show();
            
            //  Intent serviceIntent = new Intent(context, typeof(Services));
            //context.StartService(serviceIntent);
           context.StartService(new Intent(context, typeof(Services)));
        }
    }
}