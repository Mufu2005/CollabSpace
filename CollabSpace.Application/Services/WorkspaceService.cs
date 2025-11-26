using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollabSpace.Application.DTOs;
using CollabSpace.Application.Interfaces;
using CollabSpace.Domain.Entities;
using CollabSpace.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CollabSpace.Application.Services
{
    public class WorkspaceService : IWorkspaceService
    {
        private readonly ApplicationDbContext _context;

        public WorkspaceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Workspace> CreateWorkspaceAsync(CreateWorkspaceDto dto, string ownerId)
        {
            var workspace = new Workspace
            {
                Name = dto.Name,
                Description = dto.Description,
                OwnerId = ownerId,
                CreatedAt = DateTime.UtcNow
            };

            _context.Workspaces.Add(workspace);
            await _context.SaveChangesAsync();

            return workspace;
        }

        public async Task<IEnumerable<Workspace>> GetUserWorkspacesAsync(string userId)
        {
            return await _context.Workspaces
                .Where(w => w.OwnerId == userId)
                .ToListAsync();
        }
    }
}
