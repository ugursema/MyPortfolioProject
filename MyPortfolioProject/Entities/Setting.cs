namespace MyPortfolioProject.Entities
{
    public class Setting
    {
        public int SettingId { get; set; }

        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string GithubUrl { get; set; }
        public string LinkedinUrl { get; set; }

        // Admin Giriş / Profil Bilgileri
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
