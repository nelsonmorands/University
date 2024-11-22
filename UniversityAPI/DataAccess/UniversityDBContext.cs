using Microsoft.EntityFrameworkCore;
using UniversityAPI.Models.DataModels;

namespace UniversityAPI.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) { }


        // TODO: Add DbSets (Tables of our database)

        public DbSet<User>? Users { get; set; }
    }
}
