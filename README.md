# VMS_CarSales
Project Setup guide
1.	Download the source code from below URL:
Git repo : https://github.com/meghadeshpande1989/VMS_CarSales

2.	Run sql script for creating database and table used in the project.
3.	Click on the solution 
4.	Build the project and Run the same.
5.	Please note – change database name , username and password in web.config connection string
<connectionStrings>
  
    <add name="CarSalesDbEntities" connectionString="metadata=res://*/Models.EF.CarSalesVMSDb.csdl|res://*/Models.EF.CarSalesVMSDb.ssdl|res://*/Models.EF.CarSalesVMSDb.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-B2KNOQ0;initial catalog=CarSalesDb;user id=sa;password=***;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

</connectionStrings>



-------Sql script -----

Please Run the below commands in sql:


1)	To create database:
 CREATE DATABASE [CarSalesDb]

2) Create table

USE [CarSalesDb]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Car](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Engine] [nvarchar](max) NULL,
	[BodyType] [nvarchar](max) NULL,
	[Make] [nvarchar](max) NULL,
	[VehicleModel] [nvarchar](max) NULL,
	[VehicleType] [nvarchar](max) NULL,
	[Doors] [int] NULL,
	[Wheels] [int] NULL,
 CONSTRAINT [PK_dbo.Car] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

