using Abp.Application.Services;
using HelloABP.MultiTenancy.Dto;

namespace HelloABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

