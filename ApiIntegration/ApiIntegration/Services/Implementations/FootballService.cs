using ApiIntegration.API;
using ApiIntegration.DataModels;
using ApiIntegration.Services.Abstractions;
using Refit;
using System;
using System.Threading.Tasks;

namespace ApiIntegration.Services.Implementations
{
    public class FootballService : IFootballService
    {
        private readonly IFootballApi _footballApi;

        public FootballService(IFootballApi footballApi)
        {
            _footballApi = footballApi;
        }

        public async Task<Response<Сompetitions>> GetCompetitionsAsync()
        {
            try
            {
                var competitionsResponse = await _footballApi.GetCompetitionsAsync();
                if (competitionsResponse.IsSuccessStatusCode)
                {
                    return Response<Сompetitions>.Success(competitionsResponse.Content);
                }

                return Response<Сompetitions>.Fail("failed to get competitions");
            }
            catch (ApiException refitException)
            {
                return Response<Сompetitions>.Fail(refitException.Message);
            }
            catch (Exception exception)
            {
                return Response<Сompetitions>.Fail(exception.Message);
            }
        }

    }
}
