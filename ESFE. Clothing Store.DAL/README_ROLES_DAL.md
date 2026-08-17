# DAL Roles - Guía de Implementación

## 📋 Descripción
El DAL (Data Access Layer) de Roles proporciona métodos para acceder y manipular datos de roles en la base de datos usando procedimientos almacenados.

## 🛠️ Estructura del Proyecto

### Archivos Incluidos

1. **RolesDAL.cs** - Clase principal del DAL con los siguientes métodos:
   - `Insertar(Roles)` - Inserta un nuevo rol
   - `Actualizar(Roles)` - Actualiza un rol existente
   - `Eliminar(int idRoles)` - Elimina un rol
   - `ObtenerTodos()` - Obtiene todos los roles
   - `ObtenerPorId(int idRoles)` - Obtiene un rol específico

2. **SQL_Procedimientos_Roles.sql** - Contiene todos los procedimientos almacenados

## 🔧 Procedimientos Almacenados

Los siguientes procedimientos almacenados deben ser creados en la base de datos:

- `sp_Roles_Insertar` - Inserta un nuevo rol
- `sp_Roles_Actualizar` - Actualiza un rol
- `sp_Roles_Eliminar` - Elimina un rol
- `sp_Roles_ObtenerTodos` - Obtiene todos los roles
- `sp_Roles_ObtenerPorId` - Obtiene un rol por ID

## 📊 Instalación de Procedimientos

### En SQL Server Management Studio:

1. Abre SQL Server Management Studio
2. Conecta a tu servidor SQL Server
3. Selecciona la base de datos **BDDesarrollo**
4. Abre el archivo `SQL_Procedimientos_Roles.sql`
5. Ejecuta el script completo (F5)

### Desde PowerShell:

```powershell
sqlcmd -S localhost -d BDDesarrollo -i "SQL_Procedimientos_Roles.sql"
```

## 💻 Uso en el Código C#

### Ejemplo de Inserción:

```csharp
var nuevoRol = new Roles
{
	DiscripcionRoles = "Administrador"
};

int resultado = RolesDAL.Insertar(nuevoRol);
if (resultado > 0)
{
	MessageBox.Show("Rol insertado correctamente");
}
```

### Ejemplo de Consulta:

```csharp
// Obtener todos los roles
List<Roles> roles = RolesDAL.ObtenerTodos();

// Obtener un rol específico
Roles rol = RolesDAL.ObtenerPorId(1);

foreach(var rol in roles)
{
	Console.WriteLine($"ID: {rol.idRoles}, Descripción: {rol.DiscripcionRoles}");
}
```

### Ejemplo de Actualización:

```csharp
var rolActualizar = new Roles
{
	idRoles = 1,
	DiscripcionRoles = "Administrador del Sistema"
};

int resultado = RolesDAL.Actualizar(rolActualizar);
if (resultado > 0)
{
	MessageBox.Show("Rol actualizado correctamente");
}
```

### Ejemplo de Eliminación:

```csharp
int resultado = RolesDAL.Eliminar(1);
if (resultado > 0)
{
	MessageBox.Show("Rol eliminado correctamente");
}
```

## 📁 Estructura de la Tabla Roles

```sql
CREATE TABLE Roles (
	idRoles INT PRIMARY KEY IDENTITY(1,1),
	DiscripcionRoles NVARCHAR(255) NOT NULL
)
```

## ✅ Validaciones

- Se valida que la entidad no sea nula en operaciones de inserción y actualización
- Los campos de texto pueden ser nulos (se convierten a DBNull.Value)
- El ID del rol debe ser válido
- Los procedimientos almacenados incluyen manejo de errores

## 🔗 Dependencias

- Sistema.Data
- ESFE._Clothing_Store.EN (Entidades)
- Microsoft.Data.SqlClient

## 📝 Notas Importantes

1. Asegúrate de que la cadena de conexión en `DBComun.cs` sea correcta
2. Los procedimientos almacenados deben ejecutarse una sola vez en la base de datos
3. Se usa ADO.NET para las operaciones de base de datos
4. Todos los métodos son estáticos para facilitar el acceso

## 🐛 Solución de Problemas

- **Error de conexión**: Verifica la cadena de conexión en `DBComun.cs`
- **Procedimiento no encontrado**: Asegúrate de haber ejecutado el script SQL
- **Valores NULL**: Se maneja automáticamente para campos de texto

## 📌 Ejemplo Completo de Uso

```csharp
// Obtener todos los roles
var todosLosRoles = RolesDAL.ObtenerTodos();
Console.WriteLine($"Total de roles: {todosLosRoles.Count}");

// Crear nuevo rol
var nuevoRol = new Roles { DiscripcionRoles = "Vendedor" };
int filasAfectadas = RolesDAL.Insertar(nuevoRol);

if (filasAfectadas > 0)
{
	// Actualizar el rol creado
	var rolActualizado = new Roles 
	{ 
		idRoles = 1, 
		DiscripcionRoles = "Vendedor Premium" 
	};
	RolesDAL.Actualizar(rolActualizado);

	// Obtener el rol actualizado
	var rol = RolesDAL.ObtenerPorId(1);
	Console.WriteLine($"Rol actualizado: {rol.DiscripcionRoles}");
}
```
