using System;
using System.Text;

namespace VentasVOUtilidades
{
    public class VentasVO
    {
        private int comercial;
        private int empresa;
        private int[] ventasAnuales;
        private double facturacionTotal;

        public int Comercial { get => comercial; set => comercial = value; }
        public int Empresa { get => empresa; set => empresa = value; }
        public int[] VentasAnuales { get => ventasAnuales; set => ventasAnuales = value; }
        public double FacturacionTotal { get => facturacionTotal; set => facturacionTotal = value; }

        public VentasVO(int comercial, int empresa, int[] ventasAnuales)
        {
            Comercial = comercial;
            Empresa = empresa;
            VentasAnuales = ventasAnuales;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Empresa: {0}", Empresa));
            sb.AppendLine(String.Format("Facturación total (en miles de €): {0}", FacturacionTotal));
            return sb.ToString();
        }
    }
}
