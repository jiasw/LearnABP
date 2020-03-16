using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HelloABP.Roles.Dto;
using HelloABP.Users.Dto;

namespace HelloABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
