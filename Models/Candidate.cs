using System.ComponentModel.DataAnnotations;

public class Candidate
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Party { get; set; }

    public string? Platform { get; set; }

    public int TotalVotes { get; set; }
}