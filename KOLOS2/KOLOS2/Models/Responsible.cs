using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace KOLOS2.Models;

[Table("Responsible")]
[PrimaryKey(nameof(BatchId),nameof(EmployeeId))]
public class Responsible
{
    [ForeignKey("SeedlingBatch")] public int BatchId { get; set; }
    [ForeignKey("Employee")] public int EmployeeId { get; set; }
    [MaxLength(100)] public string Role { get; set; }

}