IF OBJECT_ID('dbo.Clientes', 'U') IS NULL
BEGIN
	CREATE TABLE dbo.Clientes (
		id_cliente INT IDENTITY(1,1) PRIMARY KEY,
		Nombre NVARCHAR(200) NULL,
		Dui INT NULL,
		Telefono INT NULL,
		Correo NVARCHAR(200) NULL,
		id_rol INT NULL,
		id_permiso INT NULL,
		ides