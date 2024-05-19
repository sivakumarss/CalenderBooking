
using CB.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CB.Persistence.Context;

public class CalenderBookingDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9KOABJS\SQLEXPRESS;Initial Catalog=CorePlusDemo;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public virtual DbSet<BookingSlot> BookingSlots { get; set; }

}
