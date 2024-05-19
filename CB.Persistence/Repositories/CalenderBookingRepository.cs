using CB.Application.Abstractions.Repositories;
using CB.Domain.Entities;
using CB.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CB.Persistence.Repositories;

public class CalenderBookingRepository : ICalenderBookingRepository
{
    private readonly CalenderBookingDbContext _dbContext;
    public CalenderBookingRepository(CalenderBookingDbContext dbContext) => _dbContext = dbContext;

    public async Task<IEnumerable<BookingSlot>> FindBookingAsync(string dateMonth)
    {
        var slots = await _dbContext
            .BookingSlots
            .Where(s => s.DateMonth == dateMonth)
            .OrderBy(s => s.StartTime)
            .AsNoTracking()
            .ToListAsync();
        return slots;

    }

    public async Task<bool> AddBookingAsync(BookingSlot entity)
    {
        await _dbContext.AddAsync(entity);
        _dbContext.SaveChanges();
        return true;
    }

    public async Task<bool> DeleteBookingAsync(BookingSlot entity)
    {
        var slot = await GetBookingSlotAsync(entity);
        if (slot != null)
        {
            _dbContext.Remove(slot);
            _dbContext.SaveChanges();
            return true;
        }
        return false;
    }


    public async Task<IEnumerable<BookingSlot>> GetAllBookingAsync()
    {
        var slots = await _dbContext
            .BookingSlots
            .AsNoTracking()
            .ToListAsync();
        return slots;
    }

    #region Private methods

    private async Task<BookingSlot> GetBookingSlotAsync(BookingSlot entity)
    {
        var slot = await _dbContext
            .BookingSlots
            .FirstOrDefaultAsync(s => s.DateMonth == entity.DateMonth && s.StartTime == entity.StartTime);
        return slot ?? new BookingSlot();
    }

    #endregion
}
