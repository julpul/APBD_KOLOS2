using KOLOS2.DTOs;
using KOLOS2.Exceptions;
using KOLOS2.Models;
using KOLOS2.Services;
using Microsoft.AspNetCore.Mvc;

namespace KOLOS2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NurseriesController : ControllerBase
{
    private readonly IDbService _dbService;

    public NurseriesController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}\batches")]
    public async Task<IActionResult> GetNursery(int id)
    {
        try
        {
            var result = await _dbService.GetBatcheses(id);
            return Ok(result);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
    
}