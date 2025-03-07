using FXTracker.domain.Entities;
using FXTracker.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

public class ParityRepository(ApplicationContext context) : IParityRepository
{
    public async Task AddParity(Parity parity)
    {
        context.Parities.Add(parity);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Parity>> GetParities()
    {
        return await context.Parities.AsNoTracking().ToListAsync<Parity>();
    }

    public async Task<Parity> GetParity(string symbol)
    {
        var parity = await context.Parities.AsNoTracking().FirstOrDefaultAsync(p => p.BaseCurrency == symbol);
        if (parity == null)
        {
            throw new KeyNotFoundException($"Parity with symbol '{symbol}' not found.");
        }
        return parity;
    }

    public async Task UpdateParity(Parity parity)
    {
        context.Entry(parity).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }
}