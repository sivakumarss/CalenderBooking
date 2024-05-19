using CB.Domain.Entities;

namespace CB.Application.Abstractions.Repositories;

public interface ICalenderBookingRepository
{
    Task<IEnumerable<BookingSlot>> FindBookingAsync(string dateMonth);

    Task<bool> AddBookingAsync(BookingSlot entity);
    Task<bool> DeleteBookingAsync(BookingSlot entity);
    Task<IEnumerable<BookingSlot>> GetAllBookingAsync();

}
