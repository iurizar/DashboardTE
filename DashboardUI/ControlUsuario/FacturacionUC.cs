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

namespace DashboardUI.ControlUsuario
{
    public partial class FacturacionUC : UserControl
    {
        private VentasVO[] ventas;
        private TextBox ventasEmp1;
        private TextBox ventasEmp2;
        private Label totalEmp1;
        private Label totalEmp2;
        public FacturacionUC(VentasVO[] ventas)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.ventasEmp1 = textBox1;
            this.ventasEmp2 = textBox2;
            this.totalEmp1 = labelNumTotal1;
            this.totalEmp2 = labelNumTotal2;
        }

        private void FacturacionUC_Paint(object sender, PaintEventArgs e)
        {
            foreach(int v in ventas[0].VentasAnuales)
            {
                int miles = v * 1000;
                ventasEmp1.AppendText(miles + " €\r\n");
            }

            double facTotal1 = ventas[0].FacturacionTotal * 1000;
            totalEmp1.Text = facTotal1 + " €";

            foreach (int v in ventas[1].VentasAnuales)
            {
                int miles = v * 1000;
                ventasEmp2.AppendText(miles + " €\r\n");
            }

            double facTotal2 = ventas[1].FacturacionTotal * 1000;
            totalEmp2.Text = facTotal2 + " €";

        }
    }
}
