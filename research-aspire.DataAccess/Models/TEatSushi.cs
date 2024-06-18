using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace research_aspire.DataAccess.Models;

public class TEatSushi
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(MSushiId))]
    public int MSushiId { get; set; }
    public virtual MSushi? MSushi { get; set; }

    public required string Quantity { get; set; }
}
