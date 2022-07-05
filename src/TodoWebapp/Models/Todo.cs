using System.ComponentModel.DataAnnotations;

namespace TodoWebapp.Models;

public class Todo
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsComplete { get; set; }
}
