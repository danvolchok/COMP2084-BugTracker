namespace COMP2084_BugTracker.Models
{
    public class Project
    {
        
        public int Id { get; set; } 
        public string Name { get; set; }
        public float Version { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
