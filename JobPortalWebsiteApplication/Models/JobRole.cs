namespace JobPortalWebsite.Models
{
    public class JobRole
    {
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public List<string> Experience { get; set; }
        public List<string> Skills { get; set; }
    }
}
