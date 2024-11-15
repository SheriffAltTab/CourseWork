-- Таблиця для водіїв таксопарку
CREATE TABLE Drivers (
    DriverID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    LicenseNumber NVARCHAR(20) UNIQUE NOT NULL,
    HireDate DATE NOT NULL,
    WorkingDays NVARCHAR(50) NOT NULL,  -- Наприклад, "Пн, Вт, Ср, Чт, Пт"
    WorkingAreas NVARCHAR(255) NOT NULL  -- Наприклад, "Центр, Дружба, Аляска"
);

-- Таблиця для машин
CREATE TABLE Vehicles (
    VehicleID INT PRIMARY KEY IDENTITY(1,1),
    LicensePlate NVARCHAR(10) NOT NULL UNIQUE,
    Brand NVARCHAR(50) NOT NULL,
    Model NVARCHAR(50) NOT NULL,
    Year INT NOT NULL,
    DriverID INT,
    AssignedMaster INT NULL,
    LastServiceDate DATE,  -- Дата останнього технічного обслуговування
    LastServiceDetails NVARCHAR(255),  -- Опис того, що було зроблено під час останнього технічного обслуговування
    FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID)
);

-- Таблиця для майстрів
CREATE TABLE Masters (
    MasterID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    HireDate DATE NOT NULL,
    Specialty NVARCHAR(100),  -- Наприклад, "механік", "автослюсар" тощо
    WorkingDays NVARCHAR(50) NOT NULL  -- Наприклад, "Пн, Вт, Ср, Чт, Пт"
);

-- Таблиця для операторів
CREATE TABLE Operators (
    OperatorID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    HireDate DATE NOT NULL,
    WorkingDays NVARCHAR(50) NOT NULL  -- Наприклад, "Пн, Вт, Ср, Чт, Пт"
);

-- Додавання водіїв
INSERT INTO Drivers (FirstName, LastName, BirthDate, LicenseNumber, HireDate, WorkingDays, WorkingAreas)
VALUES 
('Олександр', 'Ковальчук', '1980-01-15', 'DLI12345', '2010-05-10', 'Пн, Вт, Ср, Чт, Пт', 'Центр, Дружба'),
('Андрій', 'Петренко', '1975-06-20', 'DLI23456', '2012-08-12', 'Пн, Вт, Чт, Пт, Сб', 'Аляска, Сонячний'),
('Сергій', 'Іваненко', '1985-03-30', 'DLI34567', '2015-01-10', 'Вт, Ср, Чт, Пт, Нд', 'Центр, Березовиця');

-- Додавання машин
INSERT INTO Vehicles (LicensePlate, Brand, Model, Year, DriverID, LastServiceDate, LastServiceDetails)
VALUES 
('BO1001AK', 'Toyota', 'Corolla', 2018, 1, '2024-10-01', 'Заміна масла та фільтра'),
('BO1002AK', 'Honda', 'Civic', 2017, 2, '2024-09-15', 'Ремонт підвіски'),
('BO1003AK', 'Ford', 'Focus', 2019, 3, '2024-08-20', 'Технічний огляд');

-- Додавання майстрів
INSERT INTO Masters (FirstName, LastName, BirthDate, HireDate, Specialty, WorkingDays)
VALUES 
('Олексій', 'Павленко', '1978-05-15', '2017-01-09', 'Механік', 'Пн, Вт, Ср, Чт, Пт'),
('Марина', 'Козак', '1985-11-20', '2020-08-17', 'Автослюсар', 'Вт, Ср, Чт, Пт, Сб'),
('Світлана', 'Литвин', '1989-04-25', '2019-09-05', 'Електрик', 'Пн, Ср, Пт, Сб, Нд');

-- Додавання операторів
INSERT INTO Operators (FirstName, LastName, BirthDate, HireDate, WorkingDays)
VALUES
('Катерина', 'Петренко', '1990-02-10', '2020-05-10', 'Пн, Вт, Ср, Чт, Пт'),
('Олена', 'Сидоренко', '1988-03-22', '2019-07-15', 'Вт, Ср, Чт, Пт, Сб'),
('Віктор', 'Климчук', '1992-09-15', '2022-02-15', 'Ср, Чт, Пт, Сб, Нд');
