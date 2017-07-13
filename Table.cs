using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigacionDeOperaciones
{
    /*
     * HOLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA. Yo propongo que la tabla este compuesta
     * por arreglos de cada item. Cada item del arreglo representa un mes y cada tabla
     * representa el año.
     */
    public class Table
    {
        public double[] inventarioInicial;
        public double[] numeroAleatorio;
        public double[] demandaAjustada;
        public double[] inventarioFinal;
        public double[] faltante;
        public double[] inventarioMensualPromedio;

        public Table()
        {
            inventarioInicial = new double[12];
            numeroAleatorio = new double[12];
            demandaAjustada = new double[12];
            inventarioFinal = new double[12];
            faltante = new double[12];
            inventarioMensualPromedio = new double[12];
        }
    }
}
