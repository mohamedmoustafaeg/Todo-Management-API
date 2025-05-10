using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public enum TodoStatus
    {
        Pending,
        InProgress,
        Completed
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

    public class Todo
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public TodoStatus Status { get; set; } = TodoStatus.Pending;

        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;

        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Modified")]
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    }
}