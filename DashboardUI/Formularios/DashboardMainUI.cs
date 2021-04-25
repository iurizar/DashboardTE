using CapaBLL;
using ComercialVOUtilidades;
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
/**
 * El Dashboard utiliza iconos gratuitos con licencia libre descargados
 * de flaticon.es
 * **/
namespace DashboardUI.Formularios
{
    public partial class DashboardMainUI : Form
    {
        private Panel panelDatos;
        private UserControl inicioUC;
        private ComercialVO comercial;
        private Button buttonComercial;
        private Button buttonFacturacion;
        private Button buttonVentas;
        private Label nomUsuario;

        public DashboardMainUI()
        {
            InitializeComponent();
            panelDatos = panelData;
            buttonComercial = buttonCom;
            buttonFacturacion = buttonFac;
            buttonVentas = buttonVen;
            nomUsuario = labelUsuario;
            SetToolTips();
            inicioUC = new ControlUsuario.InicioUC();
            panelDatos.Controls.Add(inicioUC);
        }

        private void SetToolTips()
        {
            this.toolTipDashboard.SetToolTip(this.buttonComercial, "Información del comercial seleccionado");
            this.toolTipDashboard.SetToolTip(this.buttonFacturacion, "Información de factuación del comercial seleccionado");
            this.toolTipDashboard.SetToolTip(this.buttonVentas, "Resumen de ventas del comercial seleccionado");
            this.toolTipDashboard.SetToolTip(this.label1, "Menú de inicio");
            this.toolTipDashboard.SetToolTip(this.label2, "Comercial 1");
            this.toolTipDashboard.SetToolTip(this.label3, "Comercial 2");
            this.toolTipDashboard.SetToolTip(this.label4, "Comercial 3");
            this.toolTipDashboard.SetToolTip(this.nomUsuario, "Comercial seleccionado");
        }

        private void MuestraInicio(object sender, EventArgs e)
        {
            panelDatos.Controls.Clear();
            panelDatos.Controls.Add(inicioUC);
            DesactivaSubmenu();
            CambiaUsuario("USUARIO");
        }

        private void EligeComercial(object sender, EventArgs e)
        {
            panelDatos.Controls.Clear();
            Label label = (Label)sender;
            string nombre = label.Text;
            int index = nombre.IndexOf(" ");
            string nom = nombre.Substring(0, index);
            DashboardControlador controlador = new DashboardControlador();
            comercial = controlador.GestionaComercial(nom);
            
            //Nos lleva directamente a la ventana de info del Comercial
            UserControl comercialUC = new ControlUsuario.ComInfoUC(comercial);
            panelDatos.Controls.Add(comercialUC);
            ActivaSubmenu();
            CambiaUsuario(nombre);
        }

        private void MuestraComercial(object sender, EventArgs e)
        {
            panelDatos.Controls.Clear();
            UserControl comercialUC = new ControlUsuario.ComInfoUC(comercial);
            panelDatos.Controls.Add(comercialUC);
        }

        private void MuestraFacturacion(object sender, EventArgs e)
        {
            panelDatos.Controls.Clear();
            DashboardControlador controlador = new DashboardControlador(comercial);
            VentasVO[] ventas = controlador.GestionaFacturacion();
            UserControl facturacionUC = new ControlUsuario.FacturacionUC(ventas);
            panelDatos.Controls.Add(facturacionUC);
        }

        private void MuestraVentas(object sender, EventArgs e)
        {
            panelDatos.Controls.Clear();
            DashboardControlador controlador = new DashboardControlador(comercial);
            VentasVO[] ventas = controlador.GestionaFacturacion();
            UserControl ventasUC = new ControlUsuario.VentasUC(ventas, comercial);
            panelDatos.Controls.Add(ventasUC);
        }

        private void CambioEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.Silver;
            Panel panel = (Panel) label.Parent;
            panel.BackColor = Color.Silver;
            Control icono = panel.GetChildAtPoint(new Point(10,4));
            icono.BackColor = Color.Silver;
        }

        private void CambioLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.Gainsboro;
            Panel panel = (Panel)label.Parent;
            panel.BackColor = Color.Gainsboro;
            Control icono = panel.GetChildAtPoint(new Point(10, 4));
            icono.BackColor = Color.Gainsboro;
        }

        private void ActivaSubmenu()
        {
            if(comercial != null)
            {
                buttonComercial.Enabled = true;
                buttonFacturacion.Enabled = true;
                buttonVentas.Enabled = true;
            }
        }

        private void DesactivaSubmenu()
        {
            buttonComercial.Enabled = false;
            buttonFacturacion.Enabled = false;
            buttonVentas.Enabled = false;
        } 

        private void CambiaUsuario(string nombre)
        {
            nomUsuario.Text = nombre;
        }

        private void tLPInfo_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Column == 0 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, e.CellBounds);
            }
        }
    }
}
