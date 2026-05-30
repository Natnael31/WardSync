using System.ComponentModel.DataAnnotations;

namespace WardSync.Models;

public class AssignmentItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Assignment title is required.")]
    [StringLength(100)]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(500)]
    public string Description { get; set; } = "";

    [Required(ErrorMessage = "Assigned leader is required.")]
    [StringLength(100)]
    public string AssignedLeader { get; set; } = "";

    [Required(ErrorMessage = "Organization is required.")]
    [StringLength(100)]
    public string Organization { get; set; } = "";

    [Required(ErrorMessage = "Due date is required.")]
    public DateTime DueDate { get; set; } = DateTime.Today;

    [Required]
    public string Priority { get; set; } = "Medium";

    [Required]
    public string Status { get; set; } = "Open";

    [StringLength(1000)]
    public string Notes { get; set; } = "";

    public DateTime? CompletionDate { get; set; }
}