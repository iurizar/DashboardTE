using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasVOUtilidades;

namespace DashboardUI.Formularios
{
    public partial class PopupUI : Form
    {
        private VentasVO[] ventas;
        private TextBox ventasEmp1;
        private TextBox ventasEmp2;
        private Label totalEmp1;
        private Label totalEmp2;
        public PopupUI(VentasVO[] ventas)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.ventasEmp1 = textBox1;
            this.ventasEmp2 = textBox2;
            this.totalEmp1 = labelNumTotal1;
            this.totalEmp2 = labelNumTotal2;
            SetHelpers();
        }

        private void SetHelpers()
        {
            this.helpProviderPopup = new System.Windows.Forms.HelpProvider();
            this.helpProviderPopup.SetShowHelp(totalEmp1, true);
            this.helpProviderPopup.SetHelpString(totalEmp1, "Facturación total de la Empresa 1");
            this.helpProviderPopup.SetShowHelp(totalEmp2, true);
            this.helpProviderPopup.SetHelpString(totalEmp2, "Facturación total de la Empresa 2");
            this.helpProviderPopup.SetShowHelp(textBox3, true);
            this.helpProviderPopup.SetHelpString(textBox3, "Lista de meses");
            this.helpProviderPopup.SetShowHelp(textBox4, true);
            this.helpProviderPopup.SetHelpString(textBox4, "Lista de meses");
            this.helpProviderPopup.SetShowHelp(textBox1, true);
            this.helpProviderPopup.SetHelpString(textBox1, "Facturación mensual de la Empresa 1");
            this.helpProviderPopup.SetShowHelp(textBox2, true);
            this.helpProviderPopup.SetHelpString(textBox1, "Facturación mensual de la Empresa 2");
        }

        private void PopupUI_Paint(object sender, PaintEventArgs e)
        {
            foreach (int v in ventas[0].VentasAnuales)
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
