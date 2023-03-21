using System.Collections.Generic;
using Project.Roles.Dto;

namespace Project.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
