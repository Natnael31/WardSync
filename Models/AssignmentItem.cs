namespace WardSync.Models;

public class AssignmentItem
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string AssignedLeader { get; set; } = "";
    public string Organization { get; set; } = "";
    public DateTime DueDate { get; set; } = DateTime.Today;
    public string Priority { get; set; } = "Medium";
    public string Status { get; set; } = "Open";
    public string Notes { get; set; } = "";
    public DateTime? CompletionDate { get; set; }
}
