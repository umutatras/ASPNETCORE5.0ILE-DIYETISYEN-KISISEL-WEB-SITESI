using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,ApppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2GOA1TF;database=DiyetisyenProje; integrated security=true;");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ContactDynamic> ContactDynamics { get; set; }
        public DbSet<ContactStatic> ContactStatics { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<DietProgram> DietPrograms { get; set; }
    }
}
