namespace CB.Application.Constants;

public static class BookingConstant
{
    public static readonly string DateFormat = "dd/MM/yyyy HH:mm";
    public static readonly string EnteredValue = "Entered value:";
    public static readonly string FIND = "FIND";
    public static readonly string ADD = "ADD";
    public static readonly string DELETE = "DELETE";
    public static readonly string KEEP = "KEEP";
    public static readonly string AvailableSlots = "Available Slots";
    public static readonly string NoAvailableSlots = "Appointment not found !  - Please use different date in the following format:   FIND DD/MM";
    public static readonly string NotAdded = "Appointment not added !  - Please use the correct format:   ADD DD/MM hh:mm (Example: ADD 09/04 15:10 )";
    public static readonly string NotDeleted = "Appointment not deleted !  - Please use the correct format:   DELETE DD/MM hh:mm (Example: ADD 09/04 15:10 )";
    public static readonly string KeepRequirement = $"Couldnt understand the requirement for \"KEEP hh:mm keep a timeslot for any day\"";
    public static readonly string CorrectFormat = "Please use the correct format:";
    public static readonly string DateMonthTime = "DD/MM hh:mm";
    public static readonly string BookingSlotBetween9amto5pm = "The acceptable time is between 9AM and 5PM";
    public static readonly string SecondDayOfThirdWeekOfEachMonth = "The acceptable time is Except from 4 PM to 5 PM on each second day of the third week of any month";

}
