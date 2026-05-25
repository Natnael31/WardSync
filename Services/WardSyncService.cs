using Microsoft.EntityFrameworkCore;
using WardSync.Data;
using WardSync.Models;

namespace WardSync.Services;

public class WardSyncService(ApplicationDbContext db)
{
    public Task<List<Calling>> GetCallingsAsync() =>
        db.Callings.ToListAsync();

    public async Task AddCallingAsync(Calling calling)
    {
        db.Callings.Add(calling);
        await db.SaveChangesAsync();
    }

    public Task<List<AssignmentItem>> GetAssignmentsAsync() =>
        db.Assignments.ToListAsync();

    public async Task AddAssignmentAsync(AssignmentItem assignment)
    {
        db.Assignments.Add(assignment);
        await db.SaveChangesAsync();
    }

    public Task<List<FollowUpItem>> GetFollowUpsAsync() =>
        db.FollowUpItems.ToListAsync();

    public async Task AddFollowUpAsync(FollowUpItem followUp)
    {
        db.FollowUpItems.Add(followUp);
        await db.SaveChangesAsync();
    }

    public Task<List<Member>> GetMembersAsync() =>
        db.Members.ToListAsync();
}
