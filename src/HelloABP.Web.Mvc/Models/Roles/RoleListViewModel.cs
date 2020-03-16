using System.Collections.Generic;
using HelloABP.Roles.Dto;

namespace HelloABP.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
