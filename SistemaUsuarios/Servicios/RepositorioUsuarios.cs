using Dapper;
using Microsoft.Data.SqlClient;
using SistemaUsuarios.Models;

namespace SistemaUsuarios.Servicios
{
    public interface IRepositorioUsuarios
    {
        Task<int> CrearUsuario(Usuario usuario);
        Task<Usuario> BuscarUsuarioPorEmail(string emailNormalizado);
    }
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly string connectionString;
        public RepositorioUsuarios(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<int> CrearUsuario(Usuario usuario)
        {
            using var connection = new SqlConnection(connectionString);
            var usuarioId = await connection.QuerySingleAsync<int>(@"
                        INSERT INTO Usuarios (Email, EmailNormalizado, PasswordHash)
                        VALUES (@Email, @EmailNormalizado, @PasswordHash);
                        SELECT SCOPE_IDENTITY();
                        ", usuario);
            /*
             * Acá se podría agregar data por default cuando se registra un usuario nuevo para mejorar
             la experiencia por ej. a través de un stored procedure que cuando se registre un usuario
             haga un insert de varios registros para mostrar luego en el inicio
            */
            return usuarioId;
        }

        public async Task<Usuario> BuscarUsuarioPorEmail(string emailNormalizado)
        {
            using var connection = new SqlConnection(connectionString);
            var usuario = await connection.QuerySingleOrDefaultAsync<Usuario>(
                "SELECT * FROM Usuarios Where EmailNormalizado = @emailNormalizado",
                new { emailNormalizado });
            return usuario;
        }

    }
}
