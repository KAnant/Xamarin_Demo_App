using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin_ClassLibrary;

namespace Android_App
{
    public class FragmentClass : Fragment
    {
        TextView textTitle;
        ImageView image1;
        TextView textDesc;

        public PrtClass prtClass { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);

            View rootView = inflater.Inflate(Resource.Layout.Fragment, container, false);

            textTitle = rootView.FindViewById<TextView>(Resource.Id.textTitle);
            image1 = rootView.FindViewById<ImageView>(Resource.Id.image1);
            textDesc = rootView.FindViewById<TextView>(Resource.Id.textDesc);

            textTitle.Text = prtClass.Title;
            textDesc.Text = prtClass.Description;
            image1.SetImageResource(ResourceHelper.TranslateDrawable(prtClass.Image));

            return rootView;
        }
    }
}