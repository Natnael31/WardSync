using WardSync.Models;

namespace WardSync.Services;

public class WardSyncService
{
    private static readonly List<Calling> Callings = new()
    {
        new Calling
        {
            Id = 1,
            Title = "Primary Teacher",
            Organization = "Primary",
            MemberAssigned = "Sample Member",
            Status = "Open",
            NeedsFollowUp = true
        }
    };

    private static readonly List<AssignmentItem> Assignments = new()
    {
        new AssignmentItem
        {
            Id = 1,
            Title = "Youth Activity Planning",
            Description = "Plan transport and refreshments.",
            AssignedLeader = "Sample Leader",
            Organization = "Young Women",
            DueDate = DateTime.Today.AddDays(7),
            Priority = "High",
            Status = "Open"
        }
    };

    private static readonly List<FollowUpItem> FollowUps = new()
    {
        new FollowUpItem
        {
            Id = 1,
            MeetingDate = DateTime.Today,
            FollowUpItemTitle = "Ward Council Action Item",
            AssignedLeader = "Sample Leader",
            RelatedFamily = "Sample Family",
            DueDate = DateTime.Today.AddDays(7),
            Status = "Open",
            PrivacyFlag = false,
            CompletionNotes = "Sample follow-up note."
        }
    };

    private static readonly List<Member> Members = new()
    {
        new Member
        {
            Id = 1,
            FirstName = "Sarah",
            LastName = "Johnson",
            Email = "sarah@example.com",
            Phone = "555-1111",
            Organization = "Relief Society",
            CurrentCalling = "Relief Society President",
            AvailabilityNotes = "Evenings preferred",
            ActiveStatus = true
        }
    };

    public Task<List<Calling>> GetCallingsAsync()
    {
        return Task.FromResult(Callings);
    }

    public Task AddCallingAsync(Calling calling)
    {
        calling.Id = Callings.Count + 1;
        Callings.Add(calling);
        return Task.CompletedTask;
    }

    public Task<List<AssignmentItem>> GetAssignmentsAsync()
    {
        return Task.FromResult(Assignments);
    }

    public Task AddAssignmentAsync(AssignmentItem assignment)
    {
        assignment.Id = Assignments.Count + 1;
        Assignments.Add(assignment);
        return Task.CompletedTask;
    }

    public Task<List<FollowUpItem>> GetFollowUpsAsync()
    {
        return Task.FromResult(FollowUps);
    }

    public Task AddFollowUpAsync(FollowUpItem followUp)
    {
        followUp.Id = FollowUps.Count + 1;
        FollowUps.Add(followUp);
        return Task.CompletedTask;
    }

    public Task<List<Member>> GetMembersAsync()
    {
        return Task.FromResult(Members);
    }
}