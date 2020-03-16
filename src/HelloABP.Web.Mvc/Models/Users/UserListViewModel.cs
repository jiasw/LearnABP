using System.Collections.Generic;
using HelloABP.Roles.Dto;

namespace HelloABP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
