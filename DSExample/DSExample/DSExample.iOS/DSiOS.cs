using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using DSExample.iOS;
[assembly:Dependency(typeof(DSiOS)) ]
namespace DSExample.iOS
{
    public class DSiOS : IPlatformService
    {
        public string GetPlatforms()
        {
            return "Xamarin iOS";
        }
    }
}