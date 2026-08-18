-- Procedimientos Almacenados para la tabla Productos
-- Base de datos: BDDesarrollo

-- =====================================================
-- 1. INSERTAR PRODUCTO
-- =====================================================
CREATE PROCEDURE sp_Productos_Insertar
	@NombreProducto NVARCHAR(255),
	@precio NVARCHAR(50),
	@idTipoProducto INT,
	@idtallas INT,
	@idtelas INT,
	@idcolor INT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Productos 
		(NombreProducto, precio, idTipoProducto, idtallas, idtelas, idcolor)
		VALUES 
		(@NombreProducto, @precio, @idTipoProducto, @idtallas, @idtelas, @idcolor)

		RETURN @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 2. ACTUALIZAR PRODUCTO
-- =====================================================
CREATE PROCEDURE sp_Productos_Actualizar
	@CodigoProducto INT,
	@NombreProducto NVARCHAR(255),
	@precio NVARCHAR(50),
	@idTipoProducto INT,
	@idtallas INT,
	@idtelas INT,
	@idcolor INT
AS
BEGIN
	BEGIN TRY
		UPDATE Productos
		SET 
			NombreProducto = @NombreProducto,
			precio = @precio,
			idTipoProducto = @idTipoProducto,
			idtallas = @idtallas,
			idtelas = @idtelas,
			idcolor = @idcolor
		WHERE CodigoProducto = @CodigoProducto

		RETURN @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 3. ELIMINAR PRODUCTO
-- =====================================================
CREATE PROCEDURE sp_Productos_Eliminar
	@CodigoProducto INT
AS
BEGIN
	BEGIN TRY
		DELETE FROM Productos
		WHERE CodigoProducto = @CodigoProducto

		RETURN @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 4. OBTENER TODOS LOS PRODUCTOS
-- =====================================================
CREATE PROCEDURE sp_Productos_ObtenerTodos
AS
BEGIN
	BEGIN TRY
		SELECT 
			CodigoProducto,
			NombreProducto,
			precio,
			idTipoProducto,
			idtallas,
			idtelas,
			idcolor
		FROM Productos
		ORDER BY CodigoProducto DESC
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 5. OBTENER PRODUCTO POR ID
-- =====================================================
CREATE PROCEDURE sp_Productos_ObtenerPorId
	@CodigoProducto INT
AS
BEGIN
	BEGIN TRY
		SELECT 
			CodigoProducto,
			NombreProducto,
			precio,
			idTipoProducto,
			idtallas,
			idtelas,
			idcolor
		FROM Productos
		WHERE CodigoProducto = @CodigoProducto
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 6. OBTENER PRODUCTOS POR TIPO
-- =====================================================
CREATE PROCEDURE sp_Productos_ObtenerPorTipo
	@idTipoProducto INT
AS
BEGIN
	BEGIN TRY
		SELECT 
			CodigoProducto,
			NombreProducto,
			precio,
			idTipoProducto,
			idtallas,
			idtelas,
			idcolor
		FROM Productos
		WHERE idTipoProducto = @idTipoProducto
		ORDER BY CodigoProducto DESC
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO
