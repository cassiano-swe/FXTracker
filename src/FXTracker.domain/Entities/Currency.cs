namespace FXTracker.domain.Entities;
public record Currency (Guid Id, double Timestamp, string BaseCurrency, DateTime Date, string TargetCurrency, double Quote);