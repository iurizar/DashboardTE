using ComercialVOUtilidades;
using System;
using System.Data;
using System.IO;
using System.Linq;
using VentasVOUtilidades;

namespace CapaDAL
{
    public class DashboardDAL
    {
        private const string RUTACOM = "..\\..\\..\\Data\\1_datos_comerciales.csv";
        private const string RUTAFAC = "..\\..\\..\\Data\\2_facturacion_comercial.csv";

        public DashboardDAL()
        {

        }

        public VentasVO[] CargaVentas(ComercialVO comercial)
        {
            return LeeVentas(comercial);
        }

        public ComercialVO CargaComercial(string nombre)
        {
            return LeeComercial(nombre);
        }

        private ComercialVO LeeComercial(string nombre)
        {
            DataTable tabla = CSVaDatatable(RUTACOM);
            DataRow[] consulta = tabla.Select("nombre LIKE '%" + nombre + "%'");
            DataRow fila = consulta[0];
            return new ComercialVO(int.Parse((string)fila["numero_comercial"]), (string)fila["nombre"], (string)fila["apellido"], (string)fila["localidad"],
                int.Parse((string)fila["edad"]));
        }

        private VentasVO[] LeeVentas(ComercialVO comercial)
        {
            DataTable tabla = CSVaDatatable(RUTAFAC);
            DataRow[] consulta = tabla.Select("numero_comercial =" + comercial.NumComercial);
            VentasVO[] ventas = new VentasVO[consulta.Length];
            int[] ventasAnuales; ;

            for (int i = 0; i < ventas.Length; i++)
            {
                ventasAnuales = new int[12];
                int numCom = int.Parse((string)consulta[i]["numero_comercial"]);
                int numEmp = int.Parse((string)consulta[i]["numero_empresa"]);
                string[] fila = string.Join(",", consulta[i].ItemArray).Split(',').ToArray(); //Convertimos la fila en un array para leer las ventas
                for (int x = 2; x < fila.Length; x++)
                {
                    ventasAnuales[x - 2] = int.Parse(fila[x]);
                }

                ventas[i] = new VentasVO(
                    numCom,
                    numEmp,
                    ventasAnuales);
            }
            return ventas;
        }

        private DataTable CSVaDatatable(string ruta)
        {
            StreamReader sr = new StreamReader(ruta);
            string[] columnas = sr.ReadLine().Split(',');
            DataTable tabla = new DataTable();
            foreach(string columna in columnas)
            {
                tabla.Columns.Add(columna);
            }
            while(!sr.EndOfStream)
            {
                string[] filas = sr.ReadLine().Split(',');
                DataRow filaData = tabla.NewRow();
                for(int i=0; i<columnas.Length; i++)
                {
                    filaData[i] = filas[i];
                }
                tabla.Rows.Add(filaData);
            }

            return tabla;
        }
    }
}
