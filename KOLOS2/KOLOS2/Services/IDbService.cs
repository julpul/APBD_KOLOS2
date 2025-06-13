using KOLOS2.DTOs;

namespace KOLOS2.Services;

public interface IDbService
{
    public Task<NurseryDto> GetBatcheses(int id);
}