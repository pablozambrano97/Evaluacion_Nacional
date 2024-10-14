using Evaluacion_Nacional_Data;
using Evaluacion_Nacional_Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Nacional_Domain
{
    public class EmpleadosRegister
    {
        private IUsuarioData data;

        public EmpleadosRegister()
        {

            this.data = new UsuarioData();
        }

        public UsuarioDTO ValidarUsuario(UsuarioDTO usuarioDTO)
        {
            usuarioDTO = data.GetByUsuario(usuarioDTO.Rut_Usuario);
            if (usuarioDTO.Rut_Usuario != null)
            {
                throw new Exception("Empleado existente en la base de datos");
            }
            else
            {
                return usuarioDTO;
            }
        }
        public UsuarioDTO CrearEmpleado(UsuarioDTO usuarioDTO)
        {
            data.RegistrarEmpleado(usuarioDTO);
            throw new Exception("Usuario registrado con exito");
        }
    }
}
