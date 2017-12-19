using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;


namespace broadcast_example
{
    [Activity(Label = "broadcast_example", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        MySecondBroadcastReceiver myreceiver;
        IntentFilter intentfilter;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            //this.StartService(new Intent(this, typeof(Services)));
            
            // Button btnsendmessage = (Button)FindViewById(Resource.Id.sendBroadcast);

             myreceiver = new MySecondBroadcastReceiver();
            intentfilter = new IntentFilter("ActionBootCompleted");

              Intent i = new Intent("ActionBootCompleted");
               i.PutExtra("key", "some value from intent");
                 SendBroadcast(i);
                 SendOrderedBroadcast(i, null);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        //protected override void OnResume()
        //{
        //    base.OnResume();
        //}
        protected override void OnRestart()
        {
            base.OnRestart();
        }

        //protected override void OnStop()
        //{
        //    this.StartService(new Intent(this, typeof(Services)));
        //    RegisterReceiver(myreceiver, intentfilter);
        //}
        //[Android.Runtime.Register("OnPause()", "()V", "GetOnPauseHandler")]
        //protected override void OnPause()
        //{
        //    base.OnPause();
        //    UnregisterReceiver(myreceiver);
        //}
    }

    //[BroadcastReceiver(Enabled =true)]
    //public class MyBroadcastReceiver : BroadcastReceiver
    //{
    //    public override void OnReceive(Context context, Intent i)
    //    {
    //        //Toast.MakeText(context,"Received broadcast in MyBroadcastReceiver, " +
    //        //                " value received: " + i.GetStringExtra("key"),
    //        //                ToastLength.Long).Show();
    //    }
    //}
}

