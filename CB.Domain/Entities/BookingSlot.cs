using CB.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace CB.Domain.Entities;

[Table(name: "BookingSlot")]
public class BookingSlot : BaseEntity
{
    public Int64 Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public string? DateMonth { get; set; }

}