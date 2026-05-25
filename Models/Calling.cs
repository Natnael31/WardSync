namespace WardSync.Models;

public class Calling
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Organization { get; set; } = "";
    public string MemberAssigned { get; set; } = "";
    public string Status { get; set; } = "Open";
    public bool NeedsFollowUp { get; set; }
    public DateTime? DateExtended { get; set; }
    public DateTime? DateSustained { get; set; }
    public DateTime? DateReleased { get; set; }
    public string Notes { get; set; } = "";
}
