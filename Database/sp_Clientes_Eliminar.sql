IF OBJECT_ID('dbo.sp_Clientes_Eliminar', 'P') IS NOT NULL
	DROP PROCEDURE dbo.sp_Clientes_Eliminar;
GO

CREATE PROCEDURE dbo.sp_Clientes_Eliminar
	@id_cliente INT
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Clientes
	WHERE id_cliente = @id_cliente;

	SELECT @@ROWCOUNT AS FilasAfectadas;
END
GO
