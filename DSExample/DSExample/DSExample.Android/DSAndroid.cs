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
using Xamarin.Forms;
using DSExample.Droid;
[assembly: Dependency(typeof(DSAndroid))]
namespace DSExample.Droid
{
    public class DSAndroid : IPlatformService
    {
        public string GetPlatforms()
        {
            //Toda la implementación que necesitemos hacer en la plataforms
            return "Xamarin Android";
        }
    }
}