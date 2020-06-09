USE [dbchapoo09];

CREATE TABLE [Customer](
    CustomerID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Firstname nvarchar(20) NOT NULL,
    Lastname nvarchar(20) NOT NULL,
    Phonenumber nvarchar(13) NOT NULL
);

CREATE TABLE [Reservation](
    ReservationID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    CustomerID int FOREIGN KEY REFERENCES Customer(CustomerID),
    StartTime datetime NOT NULL,
	EndTime datetime NOT NULL,
	ReservationComment nvarchar(MAX),
	CustomerComment nvarchar(MAX),
	CustomerAmount int NOT NULL
);

CREATE TABLE [Table] (
	TableID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	TableStatus bit NOT NULL
);

-- Connection Table Reservation and Table
CREATE TABLE [ReservationTable](
	ReservationTableID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ReservationID int FOREIGN KEY REFERENCES Reservation(ReservationID),
	TableID int FOREIGN KEY REFERENCES [Table](TableID)
);

CREATE TABLE [Function](
    FunctionID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	FunctionName nvarchar(45) NOT NULL,
    FunctionDescription nvarchar(120) NOT NULL
);

CREATE TABLE [Employee](
	EmployeeID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(45) NOT NULL,
	LastName nvarchar(45) NOT NULL,
    EmailAdress nvarchar(120) NOT NULL,
	[Password] nvarchar(120) NOT NULL,
	FunctionID int FOREIGN KEY REFERENCES [Function](FunctionID)
)

CREATE TABLE [PaymentMethod](
    PaymentMethodID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    PaymentMethodName nvarchar(50) NOT NULL,
	PaymentMethodLink nvarchar(50) NOT NULL
);

CREATE TABLE [Payment](
    PaymentID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    PaymentTimestamp datetime NOT NULL,
    PaymentTip money,
    PaymentMethodID int FOREIGN KEY REFERENCES PaymentMethod(PaymentMethodID)
);
CREATE TABLE [OrderStatus](
	OrderStatusID int PRIMARY KEY NOT NULL,
	OrderStatusName nvarchar(100) NOT NULL
);

CREATE TABLE [Order](
    OrderID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	OrderStatusID int FOREIGN KEY REFERENCES OrderStatus(OrderStatusID) NOT NULL,
    ReservationID int FOREIGN KEY REFERENCES Reservation(ReservationID),
	PaymentID int FOREIGN KEY REFERENCES Payment(PaymentID),
	EmployeeID int FOREIGN KEY REFERENCES Employee(EmployeeID)
);

CREATE TABLE MenuType(
    MenuTypeID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    MenuName nvarchar(30) NOT NULL,
    MenuDescription nvarchar(30) NOT NULL
);

CREATE TABLE MenuItem(
    MenuItemID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    MenuItemName nvarchar(30) NOT NULL,
    ShelfLife datetime NOT NULL,
	Stock int NOT NULL,
    PricePP money NOT NULL,
	MenuTypeID int FOREIGN KEY REFERENCES MenuType(MenuTypeID)
);

--ConnectionTable Menu and Order
CREATE TABLE [MenuOrder](
    MenuOrderID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Amount int NOT NULL,
	OrderID int FOREIGN KEY REFERENCES [Order](OrderID),
	MenuItemID int FOREIGN KEY REFERENCES MenuItem(MenuItemID)
);