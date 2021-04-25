using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasVOUtilidades;
using System.Windows.Forms.DataVisualization.Charting;
using ComercialVOUtilidades;

namespace DashboardUI.ControlUsuario
{
    public partial class VentasUC : UserControl
    {
        private VentasVO[] ventas;
        private ComercialVO comercial;
        private Chart tabla;
        private Label label;
        public VentasUC(VentasVO[] ventas, ComercialVO comercial)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.comercial = comercial;
            this.tabla = chartVentas;
            this.label = labelChart;
        }

        private void VentasUC_Paint(object sender, PaintEventArgs e)
        {
            label.Text = "VENTAS MENSUALES DE " + comercial.Nombre.ToUpper() + " " + comercial.Apellido.ToUpper();
            List<string> meses = new List<string>(new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            List<int[]> ventasSerie = new List<int[]>();
            for (int i = 0; i < ventas.Length; i++)
            {
                ventasSerie.Add(ventas[i].VentasAnuales);
            }
            tabla.Series[0].Name = "Empresa 1";
            Series serie2 = new Series("Empresa 2");
            tabla.Series.Add(serie2);
            tabla.Series[0].Points.DataBindXY(meses, ventasSerie[0]);
            tabla.Series[1].Points.DataBindXY(meses, ventasSerie[1]);
            tabla.Series[0].IsValueShownAsLabel = true;
            tabla.Series[1].IsValueShownAsLabel = true;
        }
    }
}
