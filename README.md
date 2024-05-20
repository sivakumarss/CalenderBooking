# CalenderBooking
It is a Console application developed in .Net 8 with EF core Database first approach. 

To RUN:
------------
1. Create an Database in Sql Server/ Sql express   and run the SQL Query Table Create Script.sql
2. Please change the connection string in the CalenderBookingDbContext.cs
3. Please see the following image files for better understanding
   - TestRun in PS with all scenarios.jpg
   - Project folder structure.jpg
   - Database structure.jpg
   - Powershell demo.jpg
   - ConsoleApp Demo.jpg



Requirements:
-------------
- The application must accept the following commands from the command line: 
  - ADD DD/MM hh:mm to add an appointment.
  - DELETE DD/MM hh:mm to remove an appointment.
  - FIND DD/MM to find a free timeslot for the day.
  - KEEP hh:mm keep a timeslot for any day. -->> Not implemented - Functionality needs to be clarified with the TAL.
- The time slot will be always equal to 30 minutes.
- The application can assign any slot on any day, with the following constraints:
  - The acceptable time is between 9AM and 5PM
  - Except from 4 PM to 5 PM on each second day of the third week of any month - this must be reserved and unavailable
- Use SQL Server Express LocalDB for the state storage



AREAS covered:
------------------
- Console application with structured folder approach.
- Meaningful naming convention used
- Dependency injection
- Entity Framework used
- Sql sqript attached 
- Screen shot attached



Areas needs improvement:
--------------------------
- Connecting string can be configured in Key vault(Assuming Keyvault is already ready for usage)
- Logging
- Each folder can be used as Seperate class library project (Though not required for this requirement)
- Unit Testing (Setting up the Unit test project will consume some time)

![Powershell demo](https://github.com/sivakumarss/CalenderBooking/assets/20783701/b201869f-f58a-4755-9188-bc10c36edfea)
