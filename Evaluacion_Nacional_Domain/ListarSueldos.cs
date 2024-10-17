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
        public ListarSueldos()
        {
            this.data = new UsuarioData();
        }
        public List<UsuarioDTO> ListarUsuarios()
        {
            return data.Read();
        }
    }
}
