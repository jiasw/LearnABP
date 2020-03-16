using System.Collections.Generic;
using HelloABP.Roles.Dto;

namespace HelloABP.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}