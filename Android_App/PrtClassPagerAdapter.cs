using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Xamarin_ClassLibrary;

namespace Android_App
{
   public class PrtClassPagerAdapter : FragmentStatePagerAdapter 
    {
        
        public PrtClassPagerAdapter(FragmentManager fm, ManagerClass managerClass): base(fm)
        {
            this.managerClass = managerClass;
        }

        ManagerClass managerClass;

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            managerClass.MoveTo(position);
            FragmentClass fragmentClass = new FragmentClass();
            fragmentClass.prtClass = managerClass.Current;
            return fragmentClass;
        }

        public override int Count
        {
            get { return managerClass.Length; }
        }
    }
}