using System.Threading.Tasks;
using Abp.Application.Services;
using evitoriav2.Sessions.Dto;

namespace evitoriav2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
