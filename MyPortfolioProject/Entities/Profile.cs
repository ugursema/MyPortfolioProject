using System.ComponentModel.DataAnnotations;

namespace MyPortfolioProject.Entities
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

      
        public string ImageUrl { get; set; }        // Profil görselinin sunucudaki yolu (Dosya yükleme için)

        // Görseldeki Yüzen Kartlar (Floating Badges)
        public string BadgeTopTitle { get; set; }     // Örn: "Clean Code"
        public string BadgeTopSubtitle { get; set; }  // Örn: "C# & ASP.NET Core"

        public string BadgeBottomTitle { get; set; }  // Örn: "Software Engineer"
        public string BadgeBottomSubtitle { get; set; } // Örn: "Full Stack Developer"
    }
}