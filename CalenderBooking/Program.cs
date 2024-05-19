using CalenderBooking;
using CB.Application.Abstractions;
using CB.Application.Abstractions.Repositories;
using CB.Application.Service;
using CB.Persistence.Context;
using CB.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddDbContext<CalenderBookingDbContext>()
    .AddScoped<ICalenderBookingRepository, CalenderBookingRepository>()
    .AddScoped<ICalenderBookingService, CalenderBookingService>()
    .BuildServiceProvider();


Console.WriteLine("Howdy, Tal! \n");

var inputCommamds = $"ADD DD/MM hh:mm to add an appointment \n" +
                     "DELETE DD/MM hh:mm to remove an appointment \n" +
                     "FIND DD/MM to find a free timeslot for the day \n" +
                     "KEEP hh:mm keep a timeslot for any day \n";

Console.WriteLine("Please enter following commands only \n" + inputCommamds);


var booking = new CalenderBookingFeature();
booking.processCalenderBooking(serviceProvider);

