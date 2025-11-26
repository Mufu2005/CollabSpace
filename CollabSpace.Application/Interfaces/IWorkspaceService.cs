using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollabSpace.Application.DTOs;
using CollabSpace.Domain.Entities;

namespace CollabSpace.Application.Interfaces
{
    public class IWorkspaceService
    {
        Task<Workspace> CreateWorkspaceAsync(CreateWorkspaceDto dto, string ownerId);
        Task<IEnumerable<Workspace>> GetUserWorkspacesAsync(string userId);
    }
}
