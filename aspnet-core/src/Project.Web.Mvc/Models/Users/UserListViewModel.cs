using System.Collections.Generic;
using Project.Roles.Dto;

namespace Project.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
