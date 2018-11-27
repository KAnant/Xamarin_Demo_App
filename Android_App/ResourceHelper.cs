using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Android_App
{
    public static class ResourceHelper
    {
        static Dictionary<String, int> resourceDictionary = new Dictionary<string, int>();
        public static int TranslateDrawable(String drawableName)
        {
            int resourceValue = -1;
            switch (drawableName)
            {
                case "abook":
                    resourceValue = Resource.Drawable.abook;
                    break;
                case "ebook":
                    resourceValue = Resource.Drawable.ebook;
                    break;
                case "cbook":
                    resourceValue = Resource.Drawable.cbook;
                    break;
                case "dbook":
                    resourceValue = Resource.Drawable.dbook;
                    break;

            }
            return resourceValue;
        }

        public static int TranslateDrawableWithReflection(String drawableName)
        {
            int resourceValue = -1;

            if (resourceDictionary.ContainsKey(drawableName))
            {
                resourceValue = resourceDictionary[drawableName];
            }
            else
            {
                Type drawableType = typeof(Resource.Drawable);
                FieldInfo resourceFieldInfo = drawableType.GetField(drawableName);

                resourceValue = (int)resourceFieldInfo.GetValue(null);
                resourceDictionary.Add(drawableName, resourceValue);
            }
            return resourceValue;

        }
    }
}