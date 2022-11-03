/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [BookingId]
      ,[BookingName]
      ,[BookingType]
      ,[BookingNumber]
      ,[ArrivalDateTime]
      ,[DepatureDateTime]
  FROM [HBooking].[dbo].[Booking]