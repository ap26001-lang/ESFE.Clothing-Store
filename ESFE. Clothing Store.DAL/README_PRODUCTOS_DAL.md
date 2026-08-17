# DAL Productos - Guía de Implementación

## 📋 Descripción
El DAL (Data Access Layer) de Productos proporciona métodos para acceder y manipular datos de productos en la base de datos usando procedimientos almacenados.

## 🛠️ Estructura del Proyecto

### Archivos Incluidos

1. **ProductosDAL.cs** - Clase principal del DAL con los siguientes métodos:
   - `Insertar(Productos)` - Inserta un nuevo producto
   - `Actualizar(Productos)` - Actualiza un producto existente
   - `Eliminar(int codigoProducto)` - Elimina un producto
   - `ObtenerTodos()` - Obtiene todos los productos
   - `ObtenerPorId(int codigoProducto)` - Obtiene un producto específico
   - `ObtenerPorTipo(int idTipoProducto)` - Obtiene productos por tipo

2. **SQL_Procedimientos_Productos.sql** - Contiene todos los procedimientos almacenados

## 🔧 Procedimientos Almacenados

Los siguientes procedimientos almacenados deben ser creados en la base de datos:

- `sp_Productos_Insertar` - Inserta un nuevo producto
- `sp_Productos_Actualizar` - Actualiza un producto
- `sp_Productos_Eliminar` - Elimina un producto
- `sp_Productos_ObtenerTodos` - Obtiene todos los productos
- `sp_Productos_ObtenerPorId` - Obtiene un producto por ID
- `sp_Productos_ObtenerPorTipo` - Obtiene productos por tipo

## 📊 Instalación de Procedimientos

### En SQL Server Management Studio:

1. Abre SQL Server Management Studio
2. Conecta a tu servidor SQL Server
3. Selecciona la base de datos **BDDesarrollo**
4. Abre el archivo `SQL_Procedimientos_Productos.sql`
5. Ejecuta el script completo (F5)

### Desde PowerShell:

```powershell
sqlcmd -S localhost -d BDDesarrollo -i "SQL_Procedimientos_Productos.sql"
```

## 💻 Uso en el Código C#

### Ejemplo de Inserción:

```csharp
var nuevoProducto = new Productos
{
	NombreProducto = "Camiseta Premium",
	precio = "29.99",
	idTipoProducto = 1,
	idtallas = 2,
	idtelas = 3,
	idcolor = 4
};

int resultado = ProductosDAL.Insertar(nuevoProducto);
if (resultado > 0)
{
	MessageBox.Show("Producto insertado correctamente");
}
```

### Ejemplo de Consulta:

```csharp
// Obtener todos los productos
List<Productos> productos = ProductosDAL.ObtenerTodos();

// Obtener un producto específico
Productos producto = ProductosDAL.ObtenerPorId(1);

// Obtener productos por tipo
List<Productos> productosPorTipo = ProductosDAL.ObtenerPorTipo(1);
```

### Ejemplo de Actualización:

```csharp
var productoActualizar = new Productos
{
	CodigoProducto = 1,
	NombreProducto = "Camiseta Premium Actualizada",
	precio = "34.99",
	idTipoProducto = 1,
	idtallas = 2,
	idtelas = 3,
	idcolor = 4
};

int resultado = ProductosDAL.Actualizar(productoActualizar);
if (resultado > 0)
{
	MessageBox.Show("Producto actualizado correctamente");
}
```

### Ejemplo de Eliminación:

```csharp
int resultado = ProductosDAL.Eliminar(1);
if (resultado > 0)
{
	MessageBox.Show("Producto eliminado correctamente");
}
```

## 📁 Estructura de la Tabla Productos

```sql
CREATE TABLE Productos (
	CodigoProducto INT PRIMARY KEY IDENTITY(1,1),
	NombreProducto NVARCHAR(255) NOT NULL,
	precio NVARCHAR(50),
	idTipoProducto INT,
	idtallas INT,
	idtelas INT,
	idcolor INT,
	FOREIGN KEY (idTipoProducto) REFERENCES TipoProducto(idTipoProducto),
	FOREIGN KEY (idtallas) REFERENCES Tallas(idtallas),
	FOREIGN KEY (idtelas) REFERENCES Telas(idtelas),
	FOREIGN KEY (idcolor) REFERENCES Color(idcolor)
)
```

## ✅ Validaciones

- Se valida que la entidad no sea nula en operaciones de inserción y actualización
- Los campos de texto pueden ser nulos (se convierten a DBNull.Value)
- Los códigos de identificación deben ser válidos
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

