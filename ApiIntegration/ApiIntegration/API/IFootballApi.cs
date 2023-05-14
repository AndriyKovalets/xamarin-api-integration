using ApiIntegration.DataModels;
using Refit;
using System.Threading.Tasks;

namespace ApiIntegration.API
{
    public interface IFootballApi
    {
        [Get("/v4/competitions")]
        Task<ApiResponse<Сompetitions>> GetCompetitionsAsync();
    }
}
