# Sistema de Usuarios
## Proyecto de un Sistema de Usuarios desarrollado en ASP.NET MVC Core 6. 
### El sistema permite a los usuarios registrarse e iniciar sesión, proporcionando funcionalidades de autorización y autenticación. Se utiliza SQL Server como base de datos y Dapper para facilitar las consultas.

#### Características
- Registro de usuarios: Los usuarios pueden crear una cuenta proporcionando información básica como nombre de usuario, correo electrónico y contraseña.
- Inicio de sesión: Los usuarios registrados pueden iniciar sesión utilizando su nombre de usuario y contraseña.
- Autorización: El sistema gestiona la visibilidad del contenido que se muestra a cada usuario.
- Autenticación: El sistema utiliza cookies para mantener la sesión del usuario y permitir el acceso a las áreas autorizadas.
- Base de datos: Se utiliza SQL Server como base de datos para almacenar a los usuarios.
- Consultas con Dapper: utiliza Dapper para facilitar la ejecución de consultas SQL y mapear los resultados a objetos en C#.
