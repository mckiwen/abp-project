using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Project.Authorization.Roles;
using Project.Authorization.Users;
using Project.MultiTenancy;
using Project.Tasks;

namespace Project.EntityFrameworkCore
{
    public class ProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }
    }
}
