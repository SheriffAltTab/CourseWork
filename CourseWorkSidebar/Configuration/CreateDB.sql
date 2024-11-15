-- Таблиця для водіїв таксопарку
CREATE TABLE Drivers (
    DriverID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    LicenseNumber NVARCHAR(20) UNIQUE NOT NULL,
    HireDate DATE NOT NULL
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
    FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID)
);

-- Таблиця для майстрів
CREATE TABLE Masters (
    MasterID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    HireDate DATE NOT NULL,
    Specialty NVARCHAR(100)  -- Наприклад, "механік", "автослюсар" тощо
);

-- Таблиця для операторів
CREATE TABLE Operators (
    OperatorID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    HireDate DATE NOT NULL
);

-- Додавання водіїв
INSERT INTO Drivers (FirstName, LastName, BirthDate, LicenseNumber, HireDate)
VALUES 
('Олександр', 'Ковальчук', '1980-01-15', 'DLI12345', '2010-05-10'),
('Андрій', 'Петренко', '1975-06-20', 'DLI23456', '2012-08-12'),
('Сергій', 'Іваненко', '1985-03-30', 'DLI34567', '2015-01-10');

-- Додавання машин
INSERT INTO Vehicles (LicensePlate, Brand, Model, Year, DriverID)
VALUES 
('BO1001AK', 'Toyota', 'Corolla', 2018, 1),
('BO1002AK', 'Honda', 'Civic', 2017, 2),
('BO1003AK', 'Ford', 'Focus', 2019, 3);

-- Додавання майстрів
INSERT INTO Masters (FirstName, LastName, BirthDate, HireDate, Specialty)
VALUES 
('Олексій', 'Павленко', '1978-05-15', '2017-01-09', 'Механік'),
('Марина', 'Козак', '1985-11-20', '2020-08-17', 'Автослюсар'),
('Світлана', 'Литвин', '1989-04-25', '2019-09-05', 'Електрик');

-- Додавання операторів
INSERT INTO Operators (FirstName, LastName, BirthDate, HireDate)
VALUES
('Катерина', 'Петренко', '1990-02-10', '2020-05-10'),
('Олена', 'Сидоренко', '1988-03-22', '2019-07-15'),
('Віктор', 'Климчук', '1992-09-15', '2022-02-15');