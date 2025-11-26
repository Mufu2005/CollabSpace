using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabSpace.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Roles { get; set; } = "User";
        //public int NoOfProjects { get; set; }
        //public int NoOfTask{ get; set; }
        public DateTime CreatedAt { get; set; } = DateTime. UtcNow;
        public DateTime UpdatedAt { get; set; }
        //public ICollection<Project> Projects { get; set; } = new List<Project>();
        //public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
