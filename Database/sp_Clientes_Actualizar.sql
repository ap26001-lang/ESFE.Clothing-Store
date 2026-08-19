IF OBJECT_ID('dbo.sp_Clientes_Actualizar', 'P') IS NOT NULL
	DROP PROCEDURE dbo.sp_Clientes_Actualizar;
GO

CREATE PROCEDURE dbo.sp_Clientes_Actualizar
	@id_cliente INT,
	@Nombre NVARCHAR(200),
	@Dui INT,
	@Telefono INT,
	@Correo NVARCHAR(200),
	@id_rol INT,
	@id_permiso INT,
	@id_estado INT
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Clientes
	SET Nombre = @Nombre,
		Dui = @Dui,
		Telefono = @Telefono,
		Correo = @Correo,
		id_rol = @id_rol,
		id_permiso = @id_permiso,
		id_estado = @id_estado
	WHERE id_cliente = @id_cliente;

	SELECT @@ROWCOUNT AS FilasAfectadas;
END
GO
