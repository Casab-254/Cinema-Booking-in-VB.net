CREATE TABLE [dbo].[Bookings]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [First Name] NCHAR(10) NULL, 
    [Last Name] NCHAR(10) NULL, 
    [Payment no] INT NULL, 
    [Time ] TIME NULL, 
    [Date] DATE NULL, 
    [Ticket Number] NCHAR(10) NULL
)
