using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskList.Domain
{
    public class TaskItem : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }
        [Display(Name = "Is completed?")]
        public bool IsCompleted { get; set; } = false;
    }
}
