using Evaluacion_Nacional_Data;
using Evaluacion_Nacional_Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Nacional_Domain
{
    public class RegisterDomain
    {
        private IUsuarioData data;

        public RegisterDomain()
        {

            this.data = new UsuarioData();
        }
        public UsuarioDTO ValidarUsuarioYPassword(UsuarioDTO usuarioDTO)
        {
            usuarioDTO = data.GetByIdentifier(usuarioDTO.Rut_Usuario);
            if (usuarioDTO.Rut_Usuario != null)
            {
                throw new Exception("Usuario registrado, inicie sesion o recupere la contraseña");
            }
            else
            {
                return usuarioDTO;
            }
        }

        public UsuarioDTO CrearUsuario(UsuarioDTO usuarioDTO) 
        { 
            data.Create(usuarioDTO);
            throw new Exception("Usuario registrado con exito");
        }
    }
}
