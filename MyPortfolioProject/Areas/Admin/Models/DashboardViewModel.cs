using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Models
{
    public class DashboardViewModel
    {
        public int TotalProjectCount { get; set; }
        public int TotalSkillCount { get; set; }
        public int TotalMessageCount { get; set; }
        public int UnreadMessageCount { get; set; }
        public List<Project> LastProjects { get; set; }
    }
}