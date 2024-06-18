using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace research_aspire.DataAccess.Models;

public class MSushi
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required int Price { get; set; }

    [ForeignKey("CategoryId")]
    public required int CategoryId { get; set; }
    public virtual MSushiCategory? MSushiCategory { get; set; }
}
