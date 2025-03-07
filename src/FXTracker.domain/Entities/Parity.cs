namespace FXTracker.domain.Entities;
public record Parity (Guid Id, double Timestamp, string BaseCurrency, DateTime Date, string TargetCurrency, double Quote);