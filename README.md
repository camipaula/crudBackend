# Backend del Sistema de Autenticación y Gestión de Productos

Este es el repositorio para el backend del sistema de autenticación y productos. Desarrollado con **ASP.NET Core** y **Identity**, este backend proporciona endpoints para registrar usuarios, iniciar sesión y realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre productos.

## Instalación

### Requisitos Previos

Antes de empezar, se necesita tener instalado lo siguiente:

- **.NET Core SDK 6.0** o superior.
- **SQL Server** (puede ser local o en la nube).
- Un cliente REST como **Postman** (opcional para probar las API).

### Pasos para instalar

1. Clona este repositorio:
   ```bash
   git clone https://github.com/camipaula/crudBackend.git
   
2. Navega al directorio del proyecto:
   ```bash
   cd crudBackend
   
3. Configura la cadena de conexión de la base de datos en el archivo appsettings.json. Busca la sección ConnectionStrings y actualiza la configuración para tu SQL Server:
   ```bash
   "ConnectionStrings": {
     "DefaultConnection": "Server=tu_servidor;Database=TiendaDB;User Id=tu_usuario;Password=tu_contraseña;"
   }

4. Aplica las migraciones para crear la base de datos:
   ```bash
   database update

5. Ejecuta la aplicación

### USO

El backend proporciona endpoints para:

- Registrar usuarios (POST /api/auth/register)
- Iniciar sesión (POST /api/auth/login)
- Gestionar productos (CRUD):
- Obtener todos los productos: GET /api/productos
- Obtener un producto por ID: GET /api/productos/{id}
- Crear un nuevo producto: POST /api/productos
- Actualizar un producto: PUT /api/productos/{id}
- Eliminar un producto: DELETE /api/productos/{id}


