using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComercialVOUtilidades;

namespace DashboardUI.ControlUsuario
{
    public partial class ComInfoUC : UserControl
    {
        private Label lNumCom;
        private Label lNom;
        private Label lLoc;
        private Label lAge;
        private PictureBox fotoPerfil;
        private ComercialVO comercial;
        private Bitmap imagen;
        private const string RUTA = "..\\..\\..\\Data\\Perfiles\\comercial";

        public ComInfoUC(ComercialVO comercial)
        {
            InitializeComponent();
            this.comercial = comercial;
            this.lNumCom = labelNumCom;
            this.lNom = labelNomApe;
            this.lLoc = labelLocalidad;
            this.lAge = labelEdad;
            this.fotoPerfil = pictureBoxComFoto;
        }

        private void ComInfoUC_Paint(object sender, PaintEventArgs e)
        {
            lNumCom.Text = comercial.NumComercial + "";
            lNom.Text = comercial.Nombre + " " + comercial.Apellido;
            lLoc.Text = comercial.Localidad;
            lAge.Text = comercial.Edad + "";

            if(imagen != null)
            {
                imagen.Dispose();
            }
            fotoPerfil.SizeMode = PictureBoxSizeMode.Normal;
            imagen = new Bitmap(RUTA + comercial.NumComercial + ".png");
            fotoPerfil.Image = (Image)imagen;
        }
    }
}
