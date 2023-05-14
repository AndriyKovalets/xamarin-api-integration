using ApiIntegration.API;
using ApiIntegration.DataModels;
using ApiIntegration.Services.Abstractions;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace ApiIntegration.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private readonly IFootballService _footballService;

        private Сompetitions _сompetitions;
        private string _error;

        public MainPageViewModel(IFootballService footballService)
        {
            _footballService = footballService;

            Task.Run(InitAsync);
        }

        public Сompetitions Сompetitions
        {
            get => _сompetitions;
            set => SetProperty(ref _сompetitions, value);
        }

        public string Error
        {
            get => _error;
            set => SetProperty(ref _error, value);
        }

        public async Task InitAsync()
        {
            var competitionsResponse = await _footballService.GetCompetitionsAsync();
            if (competitionsResponse.IsSuccessful)
            {
                Сompetitions = competitionsResponse.Data;
            }
            else
            {
                Error = competitionsResponse.Error;
            }
        }
    }
}
