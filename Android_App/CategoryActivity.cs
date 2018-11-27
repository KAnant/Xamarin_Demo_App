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
using Xamarin_ClassLibrary;

namespace Android_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class CategoryActivity : ListActivity
    {
        CategoryManager categoryManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            //String[] categoryTitles = { "Category 1", "Category 2", "Category 3" };
            //ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, categoryTitles);

            categoryManager = new CategoryManager();
            ListAdapter = new CategoryManagerAdapter(this, Android.Resource.Layout.SimpleListItem1, categoryManager);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            Intent intent = new Intent(this, typeof(PrtActivity));
            StartActivity(intent);
        }
    }
}