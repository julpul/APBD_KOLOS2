using KOLOS2.Data;
using KOLOS2.DTOs;
using KOLOS2.Models;
using Microsoft.EntityFrameworkCore;

namespace KOLOS2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<NurseryDto> GetBatcheses(int id)
    {
        return null;
    }
    

}