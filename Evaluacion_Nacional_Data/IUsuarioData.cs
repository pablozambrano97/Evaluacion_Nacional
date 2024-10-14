using Evaluacion_Nacional_Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Nacional_Data
{
    public interface IUsuarioData
    {
        void Create(UsuarioDTO usuarioDto);
        List<UsuarioDTO> Read();
        void Update(UsuarioDTO usuarioDTO);
        void Delete(UsuarioDTO usuarioDTO);
        UsuarioDTO GetByIdentifier(string Rut_Usuario);

        void RegistrarEmpleado (UsuarioDTO usuarioDTO);

        UsuarioDTO GetByUsuario(string Rut_Empleado);
    }
}
