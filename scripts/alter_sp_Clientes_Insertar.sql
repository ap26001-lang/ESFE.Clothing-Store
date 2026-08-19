-- ALTER PROCEDURE para sp_Clientes_Insertar: declarar @id_cliente OUTPUT y asignar SCOPE_IDENTITY()
-- Ajuste los tipos y tamaños según la definición real de la tabla Clientes

IF OBJECT_ID('dbo.sp_Clientes_Insertar', 'P') IS NOT NULL
	DROP PROCEDURE dbo.sp_Clientes_Insertar;
GO

CREATE PROCEDURE dbo.sp_Clientes_Insertar
	@Nombre NVARCHAR(200),
	@Dui NVARCHAR(50),
	@Telefono NVARCHAR(50),
	@Correo NVARCHAR(200),
	@id_rol INT,
	@id_permiso INT,
	@id_estado INT,
	@id_cliente INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Clientes (Nombre, Dui, Telefono, Correo, id_rol, id_permiso, id_estado)
	VALUES (@Nombre, @Dui, @Telefono, @Correo, @id_rol, @id_permiso, @id_estado);

	SET @id_cliente = CAST(SCOPE_IDENTITY() AS INT);
END
GO
