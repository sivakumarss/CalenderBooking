using CB.Application.Abstractions.Repositories;
using CB.Application.Abstractions;
using CB.Application.Models;
using CB.Domain.Entities;

namespace CB.Application.Service
{
    public class CalenderBookingService : ICalenderBookingService
    {
        public readonly ICalenderBookingRepository _slotRepository;
        public CalenderBookingService(ICalenderBookingRepository slotRepository)
        {
            _slotRepository = slotRepository;
        }

        public async Task<IList<BookingSlotModel>> GetAllBookingAsync()
        {
            var slots = await _slotRepository.GetAllBookingAsync();

            var models = new List<BookingSlotModel>();

            foreach (var slot in slots)
            {
                var model = new BookingSlotModel()
                {
                    Id = slot.Id,
                    DateMonth = slot.DateMonth,
                    StartTime = slot.StartTime,
                    EndTime = slot.EndTime,
                };
                models.Add(model);
            }
            return models;
        }


        public async Task<IList<BookingSlotRecord>> FindBookingAsync(string input)
        {
            var dateMonth = input.Replace("FIND ", "");

            var slots = await _slotRepository.FindBookingAsync(dateMonth);
            var records = new List<BookingSlotRecord>();
            slots.ToList().ForEach(slot =>
            {
                var record = new BookingSlotRecord(slot.Id, slot.StartTime, slot.EndTime, slot.DateMonth);
                records.Add(record);
            });
            return records;
        }


        public async Task<bool> AddBookingAsync(BookingSlotModel model)
        {

            var bookingSlot = new BookingSlot()
            {
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                DateMonth = model.DateMonth,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            };

            return await _slotRepository.AddBookingAsync(bookingSlot);
        }

        public async Task<bool> DeleteBookingAsync(BookingSlotModel model)
        {
            var bookingSlot = new BookingSlot()
            {
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                DateMonth = model.DateMonth
            };

            return await _slotRepository.DeleteBookingAsync(bookingSlot);
        }


    }
}
