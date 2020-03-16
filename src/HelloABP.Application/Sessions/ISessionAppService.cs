using System.Threading.Tasks;
using Abp.Application.Services;
using HelloABP.Sessions.Dto;

namespace HelloABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
