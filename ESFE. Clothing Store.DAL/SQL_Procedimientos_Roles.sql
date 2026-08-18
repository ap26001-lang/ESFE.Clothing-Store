-- Procedimientos Almacenados para la tabla Roles
-- Base de datos: BDDesarrollo

-- =====================================================
-- 1. INSERTAR ROL
-- =====================================================
CREATE PROCEDURE sp_Roles_Insertar
	@DiscripcionRoles NVARCHAR(255)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Roles 
		(DiscripcionRoles)
		VALUES 
		(@DiscripcionRoles)

		RETURN @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 2. ACTUALIZAR ROL
-- =====================================================
CREATE PROCEDURE sp_Roles_Actualizar
	@idRoles INT,
	@DiscripcionRoles NVARCHAR(255)
AS
BEGIN
	BEGIN TRY
		UPDATE Roles
		SET 
			DiscripcionRoles = @DiscripcionRoles
		WHERE idRoles = @idRoles

		RETURN @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 3. ELIMINAR ROL
-- =====================================================
CREATE PROCEDURE sp_Roles_Eliminar
	@idRoles INT
AS
BEGIN
	BEGIN TRY
		DELETE FROM Roles
		WHERE idRoles = @idRoles

		RETURN @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 4. OBTENER TODOS LOS ROLES
-- =====================================================
CREATE PROCEDURE sp_Roles_ObtenerTodos
AS
BEGIN
	BEGIN TRY
		SELECT 
			idRoles,
			DiscripcionRoles
		FROM Roles
		ORDER BY idRoles DESC
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO

-- =====================================================
-- 5. OBTENER ROL POR ID
-- =====================================================
CREATE PROCEDURE sp_Roles_ObtenerPorId
	@idRoles INT
AS
BEGIN
	BEGIN TRY
		SELECT 
			idRoles,
			DiscripcionRoles
		FROM Roles
		WHERE idRoles = @idRoles
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
GO
