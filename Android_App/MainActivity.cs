using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin_ClassLibrary;
using System;

namespace Android_App
{
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true )]
    public class MainActivity : AppCompatActivity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        ImageView image1;
        TextView textDesc;
        ManagerClass managerClass;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            image1 = FindViewById<ImageView>(Resource.Id.image1);
            textDesc = FindViewById<TextView>(Resource.Id.textDesc);


            buttonNext.Click += ButtonNext_Click;
            buttonPrev.Click += ButtonPrev_Click;

            managerClass = new ManagerClass();
            managerClass.MoveFirst();
            UpdateUI();
        }

         void ButtonPrev_Click(object sender, System.EventArgs e)
        {
            managerClass.MovePrev();
            UpdateUI();
            //textTitle.Text = "Prev Clicked!";
            //textDesc.Text = "This is description one";
            //image1.SetImageResource(Resource.Drawable.user);
        }

         void ButtonNext_Click(object sender, System.EventArgs e)
        {
            managerClass.MoveNext();
            UpdateUI();
            //textTitle.Text = "Next Clicked!";
            //textDesc.Text = "This is description two";
            //image1.SetImageResource(Resource.Drawable.user1);
        }

        private void UpdateUI()
        {
            textTitle.Text = managerClass.Current.Title;
            textDesc.Text = managerClass.Current.Description;
            image1.SetImageResource(ResourceHelper.TranslateDrawable(managerClass.Current.Image));
            buttonPrev.Enabled = managerClass.CanMovePrev;
            buttonNext.Enabled = managerClass.CanMoveNext;
        }
    }
}