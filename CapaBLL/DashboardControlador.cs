using CalculosLib;
using CapaDAL;
using ComercialVOUtilidades;
using System;
using VentasVOUtilidades;

namespace CapaBLL
{
    public class DashboardControlador
    {
        private ComercialVO comercial;

        public DashboardControlador() { }
        public DashboardControlador(ComercialVO comercial)
        {
            this.comercial = comercial;
        }

        public ComercialVO GestionaComercial(string nombre)
        {
            return RecuperaComercial(nombre);
        }

        public VentasVO[] GestionaFacturacion()
        {
            VentasVO[] ventas = RecuperaFacturacion();
            CalculaFacturacion(ventas);
            return ventas;
        }

        public VentasVO[] GestionaVentasMensuales()
        {
            return RecuperaFacturacion();
        }
        
        private VentasVO[] RecuperaFacturacion()
        {
            DashboardDAL dal = new DashboardDAL();
            return dal.CargaVentas(comercial);
        }

        private ComercialVO RecuperaComercial(string nombre)
        {
            DashboardDAL dal = new DashboardDAL();
            return dal.CargaComercial(nombre);
        }

        private void CalculaFacturacion(VentasVO[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                ventas[i].FacturacionTotal = Calculos.SumaVentas(ventas[i].VentasAnuales);
            }
        }
    }
}
