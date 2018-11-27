using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Xamarin_ClassLibrary;

namespace Android_App
{
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    [Activity(Label ="PrtActivity")]
    public class PrtActivity : FragmentActivity
    {
        ManagerClass managerClass;
        PrtClassPagerAdapter PrtClassPagerAdapter;
        ViewPager viewPager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PrtActivity);

            managerClass = new ManagerClass();
            managerClass.MoveFirst();

            PrtClassPagerAdapter = new PrtClassPagerAdapter(SupportFragmentManager, managerClass);
            viewPager = FindViewById<ViewPager>(Resource.Id.prtPager);
            viewPager.Adapter = PrtClassPagerAdapter;

        }
    }
}