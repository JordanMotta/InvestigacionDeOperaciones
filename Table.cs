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
        public int[] inventarioInicial;
        public float[] numeroAleatorio;
        public int[] demandaAjustada;
        public int[] inventarioFinal;
        public int[] faltante;
        public int[] inventarioMensualPromedio;

        public Table()
        {
            inventarioInicial = new int[12];
            numeroAleatorio = new float[12];
            demandaAjustada = new int[12];
            inventarioFinal = new int[12];
            faltante = new int[12];
            inventarioMensualPromedio = new int[12];
        }
    }
}
