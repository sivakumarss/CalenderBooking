namespace CB.Application.Models;

public record BookingSlotRecord(long Id, DateTime StartTime, DateTime EndTime, string? DateMonth);

// This record is used for demostrative purpose only.
//// BookingSlotModel will solve the purpose of all CRUD operations.
