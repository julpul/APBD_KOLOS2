using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOLOS2.Models;

[Table("Seedling_Batch")]
public class SeedlingBatch
{
    [Key] public int BatchId { get; set; }
    [ForeignKey("Nursery")] public int NurseryId { get; set; }
    [ForeignKey("TreeSpacies")] public int SpeciesId { get; set; }
    public int Quantity { get; set; }
    public DateTime SownDate { get; set; }
    public DateTime? ReadyDate { get; set; }

    public ICollection<Responsible> Responsibles { get; set; } = null!;

}