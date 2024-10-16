using Evaluacion_Nacional_Soporte;
using Microsoft.Data.SqlClient;

namespace Evaluacion_Nacional_Data
{
    public class UsuarioData : IUsuarioData
    {
        private string ConnectionString = @"Server=localhost\SQLEXPRESS; Database=EvaluacionNacional; Integrated Security=True;TrustServerCertificate=true";
        public void Create(UsuarioDTO usuarioDto)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string commandString = $@"INSERT INTO [dbo].[Usuarios]
               VALUES ('{usuarioDto.Rut_Usuario}',
                       '{usuarioDto.Password}',
                       'EMPLEADO',
                        0)";
            SqlCommand command = new SqlCommand(commandString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(UsuarioDTO usuarioDTO)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO GetByIdentifier(string Rut_Usuario)
        {
            UsuarioDTO returnData = new UsuarioDTO();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string commandString = $@"SELECT [Rut_Usuario]
                                            ,[Password_Usuario]
                                            ,[Rol_Usuario]
                                            FROM [dbo].[Usuarios]
                                            WHERE Flag_Borrado = 0 and Rut_Usuario = '{Rut_Usuario}'";

            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                returnData = new UsuarioDTO()
                {
                    Rut_Usuario = reader.GetString(0),
                    Password = reader.GetString(1),
                    Rol_Usuario = reader.GetString(2)
                };

            }
            connection.Close();

            if (returnData.Rut_Usuario == string.Empty)
                throw new Exception("No se encontraron elementos");

            return returnData;
        }

        public UsuarioDTO GetByUsuario(string Rut_Empleado)
        {
            UsuarioDTO returnData = new UsuarioDTO();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string commandString = $@"SELECT [Rut_Empleado]
                                            FROM [dbo].[Empleado]
                                            WHERE Rut_Empleado = '{Rut_Empleado}'";

            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                returnData = new UsuarioDTO()
                {
                    Rut_Usuario = reader.GetString(0)
                };
            }
            connection.Close();

            if (returnData.Rut_Usuario == string.Empty)
                throw new Exception("No se encontraron elementos");

            return returnData;
        }

        public UsuarioDTO GetHorasByUsuario(string Rut_Empleado)
        {
            UsuarioDTO returnData = new UsuarioDTO();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string commandString = $@"SELECT [Rut_Empleado]
                                            ,[Valor_Hora_Empleado]
                                            ,[Valor_Hora_Extra_Empleado]
                                            FROM [dbo].[Empleado]
                                            WHERE Rut_Empleado = '{Rut_Empleado}'";

            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                returnData = new UsuarioDTO()
                {
                    Rut_Usuario = reader.GetString(0),
                    Valor_Hora = reader.GetInt32(1),
                    Valor_Hora_Extra = reader.GetInt32(2)
                };

            }
            connection.Close();

            if (returnData.Rut_Usuario == string.Empty)
                throw new Exception("Empleado no registrado.");

            return returnData;
        }

        public List<UsuarioDTO> Read()
        {
            throw new NotImplementedException();
        }

        public void RegistrarEmpleado(UsuarioDTO usuarioDTO)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string commandString = $@"INSERT INTO [dbo].[Empleado]
               VALUES ('{usuarioDTO.Rut_Usuario}',
                       '{usuarioDTO.Nombre}',
                       '{usuarioDTO.Direccion}',
                       '{usuarioDTO.Telefono}',
                       '{usuarioDTO.Valor_Hora}',
                       '{usuarioDTO.Valor_Hora_Extra}')";
            SqlCommand command = new SqlCommand(commandString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void RegistrarSueldoByEmpleado(UsuarioDTO usuarioDTO)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string commandString = $@"INSERT INTO [dbo].[Sueldo_Empleado]
               VALUES ('{usuarioDTO.SueldoBruto}',
                       '{usuarioDTO.SueldoLiquido}',
                       '{usuarioDTO.Horas_Trabajadas}',
                       '{usuarioDTO.Horas_Extras_Trabajadas}',
                       '{usuarioDTO.Salud}',
                       '{usuarioDTO.AFP}',
                       '{usuarioDTO.Rut_Usuario}')";
            SqlCommand command = new SqlCommand(commandString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(UsuarioDTO usuarioDTO)
        {
            throw new NotImplementedException();
        }
    }
}
