using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabSpace.Domain.Entities
{
    public class Task
    {
        Guid Id { get; set; } = Guid.NewGuid();
        string CreatedBy { get; set; }
        string TaskTitle { get; set; }
        string TaskDescription { get; set; }
        string AssignedTo { get; set; }
        string Status { get; set; } = "ToDo";
        DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime UpdatedAt { get; set; }
        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
