using Evaluacion_Nacional_Data;
using Evaluacion_Nacional_Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Evaluacion_Nacional_Domain
{
    public class SueldoRegister
    {
        private IUsuarioData data;
        public SueldoRegister()
        {
            this.data = new UsuarioData();
        }
        public UsuarioDTO ConsultarValorHoras(UsuarioDTO usuarioDTO)
        {
            usuarioDTO = data.GetHorasByUsuario(usuarioDTO.Rut_Usuario);
            if (usuarioDTO.Rut_Usuario == null)
            {
                throw new Exception("Empleado no registrado en la base de datos");
            }
            else
            {
                return usuarioDTO;
            }
        }

        public UsuarioDTO RegistrarSueldoByEmpleado(UsuarioDTO usuarioDTO)
        {
            data.RegistrarSueldoByEmpleado(usuarioDTO);
            throw new Exception($@"Sueldo Empleado {usuarioDTO.Rut_Usuario} registrado con exito");
        }
    }
}
