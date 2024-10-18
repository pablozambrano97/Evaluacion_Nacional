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
        public int Valor_Hora { get; set; }
        public int Valor_Hora_Extra { get;set; }
        public float Horas_Trabajadas   { get; set; }
        public float Horas_Extras_Trabajadas { get; set; }

        public string AFP { get; set; }
        public string Salud {  get; set; }
        public double SueldoBruto { get; set; }
        public double SueldoLiquido { get; set; }
        
        public bool EsAdmin { get; set; }
        public bool FlagEdicion {  get; set; }

    }
}
