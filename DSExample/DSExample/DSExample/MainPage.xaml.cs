using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Label.Text = Xamarin.Forms.DependencyService.Get<IPlatformService>().GetPlatforms();
        }
    }
}
