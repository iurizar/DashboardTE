using System;
using System.Text;

namespace ComercialVOUtilidades
{
    public class ComercialVO
    {
        private int numComercial;
        private string nombre;
        private string apellido;
        private string localidad;
        private int edad;

        public int NumComercial { get => numComercial; set => numComercial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Edad { get => edad; set => edad = value; }

        public ComercialVO(int numComercial, string nombre, string apellido, string localidad, int edad)
        {
            NumComercial = numComercial;
            Nombre = nombre;
            Apellido = apellido;
            Localidad = localidad;
            Edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("{0,-25}{1,-25}", "Nº de comercial:", NumComercial)); //16
            sb.AppendLine(String.Format("{0, -22}{1} {2}", "Nombre y apellidos:", Nombre, Apellido)); //19
            sb.AppendLine(String.Format("{0,-29}{1}", "Localidad:", Localidad)); //10
            sb.AppendLine(String.Format("{0,-32}{1}", "Edad:", Edad)); //5
            return sb.ToString();
        }
    }
}
