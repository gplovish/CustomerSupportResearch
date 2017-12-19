package md5bae28d005e942aa350bc53980403a617;


public class MySecondBroadcastReceiver
	extends android.content.BroadcastReceiver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceive:(Landroid/content/Context;Landroid/content/Intent;)V:GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("broadcast_example.MySecondBroadcastReceiver, broadcast_example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MySecondBroadcastReceiver.class, __md_methods);
	}


	public MySecondBroadcastReceiver () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MySecondBroadcastReceiver.class)
			mono.android.TypeManager.Activate ("broadcast_example.MySecondBroadcastReceiver, broadcast_example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onReceive (android.content.Context p0, android.content.Intent p1)
	{
		n_onReceive (p0, p1);
	}

	private native void n_onReceive (android.content.Context p0, android.content.Intent p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
