using Android.Content;
using Android.Views;
using Android.Widget;
using System;

using Xamarin_ClassLibrary;

namespace Android_App
{
    internal class CategoryManagerAdapter : BaseAdapter<CategoryClass>
    {
        Context context;
        int layoutResourceId;
        CategoryManager categoryManager;

        public CategoryManagerAdapter (Context context, int layoutResourceId, CategoryManager categoryManager)
        {
            this.context = context;
            this.layoutResourceId = layoutResourceId;
            this.categoryManager = categoryManager;
        }
        public override CategoryClass this[int position]
        {
            get
            {
                categoryManager.MoveTo(position);
                return categoryManager.Current;
            }
        }

        public override int Count
        {
            get { return categoryManager.Length; }
        }

        public override long GetItemId(int position)
        {
             return position; 
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if(view==null)
            {
                LayoutInflater inflater = context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
                view = inflater.Inflate(layoutResourceId, null);
            }

            TextView textView = view.FindViewById<TextView>(Android.Resource.Id.Text1);
            textView.Text = this[position].Title;
            return view;
        }
    }
}
