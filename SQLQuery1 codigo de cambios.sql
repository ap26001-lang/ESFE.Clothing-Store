USE TIENDA_ROPA;
GO

CREATE TABLE Usuario (
    Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(100),
    Correo VARCHAR(100),
    Clave VARCHAR(100),
    id_Rol INT
);
GO

INSERT INTO Usuario (Usuario, Correo, Clave, id_Rol) VALUES
('Vendedor, Luis', 'luis@maisonelite.com', '123456', 303),
('Vendedor, Diego', 'diego@maisonelite.com', '123456', 303),
('Vendedor, Edwin', 'edwin@maisonelite.com', '123456', 303),
('Vendedor, Bernardo', 'bernardo@maisonelite.com', '123456', 303),
('Admin, Carlos', 'admincarlos@maisonelite.com', 'Admin123*', 101),
('Cliente, Ana', 'anacliente@gmail.com', 'Cliente123*', 202);
GO