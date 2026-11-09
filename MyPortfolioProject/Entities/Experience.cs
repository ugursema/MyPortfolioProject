namespace MyPortfolioProject.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string title {  get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string SideTitle { get; set; }
        public string Duration { get; set; }
        public string WorkType { get; set; }
        public bool IsActive { get; set; }
    }
}
