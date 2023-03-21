using System.Collections.Generic;
using Project.Roles.Dto;

namespace Project.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}