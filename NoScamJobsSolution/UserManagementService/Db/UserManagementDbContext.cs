using Microsoft.EntityFrameworkCore;
using UserManagementService.Models;

namespace UserManagementService.Db
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions options) : base(options)
        {
        }

        public required DbSet<Users> Users { get; set; }
    }
}
