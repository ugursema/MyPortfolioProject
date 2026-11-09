using Microsoft.EntityFrameworkCore;
using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Context
{
    //veritabanı bağlantısı için burayı kullanacağız
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PortfolioDbProject;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<AboutRight> AboutRights { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Profile> Profiles { get; set; }

    }
}
//override 
//DbContextOptionsBuilder veritabanı bağlantı ayarlarını insa etmek 