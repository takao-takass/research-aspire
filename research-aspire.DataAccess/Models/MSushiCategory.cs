using System.ComponentModel.DataAnnotations;

namespace research_aspire.DataAccess.Models;

public class MSushiCategory
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }

    public virtual ICollection<MSushi> Sushis { get; set; } = [];
}
