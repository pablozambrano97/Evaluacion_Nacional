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
    public class ListarSueldos
    {
        private IUsuarioData data;
        private UsuarioDTO usuarioDTO { get; set; }
        public ListarSueldos()
        {
            this.data = new UsuarioData();
            usuarioDTO = new UsuarioDTO();
        }
        public List<UsuarioDTO> ListarUsuarios(UsuarioDTO usuario)
        {   
            if (usuario.EsAdmin)
            {
                return data.Read();
            }
            else
            {
                return data.GetSueldoByIdList(usuario.Rut_Usuario);
            }
        }
        public void EliminarSueldo(UsuarioDTO usuarioDTO)
        {
                data.Delete(usuarioDTO);
                throw new Exception($@"Empleado {usuarioDTO.Rut_Usuario} eliminado con exito");
        }

    }
}
