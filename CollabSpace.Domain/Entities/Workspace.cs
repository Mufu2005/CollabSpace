using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabSpace.Domain.Entities
{
    public class Workspace
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // The ID of the user who created this workspace (The Owner)
        public string OwnerId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties (We will add these later for relationships)
        // public ICollection<ProjectTask> Projects { get; set; }
        // public ICollection<User> Members { get; set; }
    }
}
