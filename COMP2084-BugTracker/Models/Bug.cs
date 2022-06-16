using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084_BugTracker.Models

{
    public class Bug
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }


        // a foreign key pointing to primary key in Project
        [ForeignKey("Project")]


        public int? ProjectId { get; set; }
        public Project? Project { get; set; } 
    } 
}
