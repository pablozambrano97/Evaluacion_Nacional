using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Nacional_Soporte
{
    public class UsuarioDTO
    {
        public string Rut_Usuario {  get; set; }
        public string Password { get; set; }
        public string Rol_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Valor_Hora { get; set; }
        public string Valor_Hora_Extra { get;set; }

    }
}
