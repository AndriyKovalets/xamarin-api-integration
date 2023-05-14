using ApiIntegration.API;
using ApiIntegration.Settings;
using Refit;

namespace ApiIntegration.Factories
{
    public static class FootballApiFactory
    {
        public static IFootballApi Create()
        {
            return RestService.For<IFootballApi>(AppSettings.BaseUrl);
        }
    }
}
