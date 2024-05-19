using CB.Application.Models;

namespace CB.Application.Abstractions;

public interface ICalenderBookingService
{
    Task<IList<BookingSlotModel>> GetAllBookingAsync();
    Task<IList<BookingSlotRecord>> FindBookingAsync(string input);
    Task<bool> AddBookingAsync(BookingSlotModel model);
    Task<bool> DeleteBookingAsync(BookingSlotModel model);
}
