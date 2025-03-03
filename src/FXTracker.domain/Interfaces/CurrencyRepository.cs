using FXTracker.domain.Entities;

namespace FXTracker.domain.Interfaces;

public interface CurrencyRepository{
    Task<Currency> GetCurrencies();
    Task<Currency> GetCurrency(string symbol);
    Task<Currency> AddCurrency(Currency currency);
    Task<Currency> UpdateCurrency(Currency currency);  
}