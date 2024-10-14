using Evaluacion_Nacional_Data;
using Evaluacion_Nacional_Soporte;


namespace Evaluacion_Nacional_Domain
{
    public class LoginDomain
    {
        private IUsuarioData data;
        public LoginDomain()
        {

            this.data = new UsuarioData();
        }

        public UsuarioDTO ValidarUsuarioYPassword(string Rut_Usuario, string password)
        {
            UsuarioDTO usuarioDTO = data.GetByIdentifier(Rut_Usuario);
            if (usuarioDTO.Password == password)
            {
                return usuarioDTO;
            }

            throw new Exception("Usuario y contraseña no coinciden");
        }
    }
}
