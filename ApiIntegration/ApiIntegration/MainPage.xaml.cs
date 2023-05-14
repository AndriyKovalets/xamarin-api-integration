using ApiIntegration.DataModels;
using ApiIntegration.Factories;
using ApiIntegration.Services.Implementations;
using ApiIntegration.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace ApiIntegration
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            On<iOS>().SetUseSafeArea(true);

            var footballApi = FootballApiFactory.Create();
            var footballService = new FootballService(footballApi);
            BindingContext = new MainPageViewModel(footballService);
        }
    }
}
