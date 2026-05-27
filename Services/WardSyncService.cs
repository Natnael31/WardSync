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


    public async Task UpdateCallingAsync(Calling calling)
    {
        var existingCalling = await db.Callings.FindAsync(calling.Id);
        if (existingCalling != null)
        {
            existingCalling.Title = calling.Title;
            existingCalling.Organization = calling.Organization;
            existingCalling.MemberAssigned = calling.MemberAssigned;
            existingCalling.Status = calling.Status;
            existingCalling.NeedsFollowUp = calling.NeedsFollowUp;
            existingCalling.DateExtended = calling.DateExtended;
            existingCalling.DateSustained = calling.DateSustained;
            existingCalling.DateReleased = calling.DateReleased;
            existingCalling.Notes = calling.Notes;

            await db.SaveChangesAsync();
        }
    }

    public async Task DeleteCallingAsync(int id)
    {
        var calling = await db.Callings.FindAsync(id);
        if (calling != null)
        {
            db.Callings.Remove(calling);
            await db.SaveChangesAsync();
        }
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
