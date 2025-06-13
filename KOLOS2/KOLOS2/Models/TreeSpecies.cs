using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOLOS2.Models;

[Table("Tree_Species")]
public class TreeSpecies
{
    [Key] public int SpaciesId { get; set; }
    [MaxLength(100)] public string LatinName { get; set; }
    public int GrowthTimeInYears { get; set; }

    public ICollection<SeedlingBatch> TreeSpeciesSeedlingBatches { get; set; } = null!;
}