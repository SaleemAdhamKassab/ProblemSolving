use C21_DB1;

-- Common Date funcitons:

-- Getting the current system date and time
SELECT GETDATE() AS CurrentDateTime
GO

-- Getting the system date and time with fractional seconds and time zone offset
SELECT SYSDATETIME() AS SystemDateTime
GO

-- Adding 10 days to the current date
SELECT DATEADD(day, 10, GETDATE()) AS DatePlus10Days
GO

-- Calculating the difference in days between two dates
SELECT DATEDIFF(day, '2023-01-01', GETDATE()) AS DaysSinceStartOfYear
GO

-- Extracting the year part from the current date
SELECT DATEPART(year, GETDATE()) AS CurrentYear
GO

-- Getting the name of the current month
SELECT DATENAME(month, GETDATE()) AS CurrentMonthName
GO

-- Extracting the day from the current date
SELECT DAY(GETDATE()) AS CurrentDay
GO

-- Extracting the month from the current date
SELECT MONTH(GETDATE()) AS CurrentMonth
GO

-- Extracting the year from the current date
SELECT YEAR(GETDATE()) AS CurrentYear
GO

-- Converting a datetime to a different format,The third argument, 103, specifies the style code for the conversion. 
--In SQL Server, style code 103 represents the date format as DD/MM/YYYY. 
--This means that the resulting string will have the day, then the month, and finally the year, separated by forward slashes.
SELECT CONVERT(varchar, GETDATE(), 103) AS DateInDDMMYYYY
GO

-- Casting a datetime to a different data type
SELECT CAST(GETDATE() AS date) AS DateOnly
GO

-- Getting the last day of the current month
SELECT EOMONTH(GETDATE()) AS LastDayOfCurrentMonth
GO
