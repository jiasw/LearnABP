using System.Threading.Tasks;
using Abp.Application.Services;
using HelloABP.Authorization.Accounts.Dto;

namespace HelloABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
