using FXTracker.domain.Entities;

namespace FXTracker.domain.Interfaces;

public interface IParityRepository{
    Task<IEnumerable<Parity>> GetParities();
    Task<Parity> GetParity(string symbol);
    Task AddParity(Parity parity);
    Task UpdateParity(Parity parity);  
}