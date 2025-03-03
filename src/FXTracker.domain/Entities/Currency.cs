namespace FXTracker.domain.Entities;
public record Currency (Guid Id, double Timestamp, string Symbol, DateTime Date, Dictionary<string, double> Parity);