using KOLOS2.Models;

namespace KOLOS2.DTOs;

public class NurseryDto
{
    public int nurseryId { get; set; }
    public string name { get; set; }
    public DateTime establishedDate { get; set; }
    public List<BatchDto> batches { get; set; }
}

public class BatchDto
{
    public int batcheId { get; set; }
    public int quantity { get; set; }
    public DateTime sownDate { get; set; }
    public DateTime? readyDate { get; set; }
    public SpacieDto spacies { get; set; }
    public List<ResponsibleDto> responsible { get; set; }
}

public class SpacieDto
{
    public string latinName { get; set; }
    public int growthTimeInYears{ get; set; }
}

public class ResponsibleDto
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string role { get; set; }
}
