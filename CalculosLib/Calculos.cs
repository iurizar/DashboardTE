using System;
using VentasVOUtilidades;

namespace CalculosLib
{
    public class Calculos
    {
        public static int SumaVentas(int[] ventas)
        {
            int sumaTotal = 0; ;
            foreach(int venta in ventas)
            {
                sumaTotal += venta;
            }
            return sumaTotal;
        }
    }
}
