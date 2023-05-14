using ApiIntegration.DataModels;
using System.Threading.Tasks;

namespace ApiIntegration.Services.Abstractions
{
    public interface IFootballService
    {
        Task<Response<Сompetitions>> GetCompetitionsAsync();
    }
}
