USE [RENTACAR]
GO

-- Insertar registros de ejemplo en la tabla FLOTA_ADMINISTRATIVA
INSERT INTO [dbo].[FLOTA_ADMINISTRATIVA] 
    ([Modelo], [Marca], [Anio], [TipoDeVehiculo], [MontoPorDia], [MontoDeSeguro], [FechaDeRegistro], [FechaDeModificacion], [Estado])
VALUES
    ('Civic', 'Honda', '2020', 1, 75.00, 15.00, GETDATE(), NULL, 1),
    ('Corolla', 'Toyota', '2019', 1, 70.00, 12.00, GETDATE(), NULL, 1),
    ('F-150', 'Ford', '2021', 2, 90.00, 18.50, GETDATE(), NULL, 1),
    ('Sprinter', 'Mercedes-Benz', '2020', 3, 120.00, 22.00, GETDATE(), NULL, 1),
    ('Model 3', 'Tesla', '2022', 1, 100.00, 20.00, GETDATE(), NULL, 1),
    ('RAV4', 'Toyota', '2018', 2, 85.00, 16.00, GETDATE(), NULL, 1),
    ('Explorer', 'Ford', '2019', 2, 80.00, 17.50, GETDATE(), NULL, 0),
    ('Kona', 'Hyundai', '2021', 1, 65.00, 12.50, GETDATE(), NULL, 1),
    ('Transit', 'Ford', '2017', 3, 110.00, 20.00, GETDATE(), NULL, 0),
    ('X5', 'BMW', '2021', 2, 130.00, 25.00, GETDATE(), NULL, 1),
	('Civic SI', 'Honda', '2024', 1, 75.00, 15.00, GETDATE(), NULL, 1),
    ('Corolla Sport', 'Toyota', '2024', 1, 70.00, 12.00, GETDATE(), NULL, 1),
    ('F-150 Lobo', 'Ford', '2024', 2, 90.00, 18.50, GETDATE(), NULL, 1),
    ('Sprinter S', 'Mercedes-Benz', '2023', 3, 120.00, 22.00, GETDATE(), NULL, 1),
    ('Model X', 'Tesla', '2023', 1, 100.00, 20.00, GETDATE(), NULL, 1),
    ('RAV4 Hybrid', 'Toyota', '2024', 2, 85.00, 16.00, GETDATE(), NULL, 1),
    ('Explorer Platinum', 'Ford', '2024', 2, 80.00, 17.50, GETDATE(), NULL, 0),
    ('Tucson', 'Hyundai', '2024', 1, 65.00, 12.50, GETDATE(), NULL, 1),
    ('Ranger', 'Ford', '2017', 3, 110.00, 20.00, GETDATE(), NULL, 0),
    ('X6', 'BMW', '2024', 2, 130.00, 25.00, GETDATE(), NULL, 1);


GO

-- Insertar registros de ejemplo en la tabla RESERVACIONES
INSERT INTO [dbo].[RESERVACIONES]
    ([NombreCliente], [Telefono], [Correo], [Identificacion], [FechaNacimiento], [TarjetaDeCredito], 
     [IdVehiculo], [MontoPorDia], [MontoSeguro], [FechaInicio], [FechaFin], 
     [FechaDeRegistro], [CantidadDeDias], [Estado])
VALUES
    ('Juan Pérez', '5551234567', 'juan.perez@email.com', 'A123456789', '1985-05-14', '1234', 
     1, 75.00, 15.00, '2024-11-01', '2024-11-05', GETDATE(), 4, 1),
     
    ('Ana Gómez', '5557654321', 'ana.gomez@email.com', 'B987654321', '1990-08-22', '5678', 
     2, 70.00, 12.00, '2024-12-10', '2024-12-15', GETDATE(), 5, 1),
     
    ('Carlos López', '5558765432', 'carlos.lopez@email.com', 'C135792468', '1975-03-09', '4321', 
     3, 90.00, 18.50, '2024-11-20', '2024-11-25', GETDATE(), 5, 1),
     
    ('María Fernández', '5552345678', 'maria.fernandez@email.com', 'D246813579', '1988-11-17', '8765', 
     4, 120.00, 22.00, '2024-11-10', '2024-11-13', GETDATE(), 3, 1),
     
    ('Luis Ramírez', '5553456789', 'luis.ramirez@email.com', 'E112233445', '1993-01-02', '3456', 
     5, 100.00, 20.00, '2024-11-22', '2024-11-27', GETDATE(), 5, 1),
     
    ('Elena Rojas', '5554567890', 'elena.rojas@email.com', 'F556677889', '1982-07-30', '2345', 
     6, 85.00, 16.00, '2024-11-02', '2024-11-07', GETDATE(), 5, 1),
     
    ('Miguel Martínez', '5556781234', 'miguel.martinez@email.com', 'G998877665', '1970-09-11', '6789', 
     7, 80.00, 17.50, '2024-11-12', '2024-11-15', GETDATE(), 3, 0),
     
    ('Patricia Sánchez', '5557890123', 'patricia.sanchez@email.com', 'H334455667', '1995-04-18', '9876', 
     8, 65.00, 12.50, '2024-12-01', '2024-12-06', GETDATE(), 5, 1),
     
    ('Roberto García', '5558901234', 'roberto.garcia@email.com', 'I776655443', '1980-02-15', '5432', 
     9, 110.00, 20.00, '2024-11-14', '2024-11-18', GETDATE(), 4, 1),
     
    ('Laura Torres', '5559012345', 'laura.torres@email.com', 'J223344556', '1987-10-25', '0987', 
     10, 130.00, 25.00, '2024-11-18', '2024-11-23', GETDATE(), 5, 1);