using System.ComponentModel.DataAnnotations;

namespace Microsoft.EntityFrameworkCore;

public class UpdateTodoRequest
{
    public UpdateTodoRequest()
    {
        IsComplete = false;
    }

    [StringLength(100)] public string Title { get; set; }

    [StringLength(500)] public string Description { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? DueDate { get; set; }

    [Range(1, 5)] public int? Priority { get; set; }
}