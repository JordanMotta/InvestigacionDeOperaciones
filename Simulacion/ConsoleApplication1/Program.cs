using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        public static double[] listaNumerosAleatorios() {
            Random seed = new Random();
            
            System.Threading.Thread.Sleep(10*seed.Next(10));

            Random rnd = new Random(seed.Next(100));
            double[] aleatorios = new double[] {
            rnd.NextDouble()  //0
            ,rnd.NextDouble() //1
            ,rnd.NextDouble() //2
            ,rnd.NextDouble() //3
            ,rnd.NextDouble() //4
            ,rnd.NextDouble() //5
            ,rnd.NextDouble() //6
            ,rnd.NextDouble() //7
            ,rnd.NextDouble() //8
            ,rnd.NextDouble() //9
            ,rnd.NextDouble() //10
            ,rnd.NextDouble() //11
            ,rnd.NextDouble() //12
            //para pedidos
            ,rnd.NextDouble() //13
            ,rnd.NextDouble() //14
            ,rnd.NextDouble() //15
            ,rnd.NextDouble() //16
            ,rnd.NextDouble() //17
            ,rnd.NextDouble() //18
            ,rnd.NextDouble() //19
            ,rnd.NextDouble() //20
            ,rnd.NextDouble() //21
            ,rnd.NextDouble() //22
            ,rnd.NextDouble() //23
            ,rnd.NextDouble() //24

        };
            //rnd = null;
           
         
            rnd = null;
            return aleatorios;
        }

        /*


        int mesLlegadaOrden;
        bool pedidoRealizado;


        public void simulacionInventario(){
	
        }
                 */

public class demanda{
	double limiteInferior;
	double limiteSuperior;
	int x;
            public demanda(double limiteInferior,double limiteSuperior,int x){
                this.limiteInferior = limiteInferior;
                this.limiteSuperior = limiteSuperior;
                this.x = x;
            }
            public double getInferior() { return this.limiteInferior; }
            public double geSuperior() { return this.limiteSuperior; }
            public int getX() { return this.x; }
}


       

        public static int valorDemanda(double numeroAleatorio, demanda[] valoresDemanda)
        {
            int size = valoresDemanda.Length;
            int index = 0;
            foreach (demanda rango in valoresDemanda)
            {
                index++;

                if ((numeroAleatorio >= rango.getInferior()) )
                {
                    if (index == size)
                    {
                        if ((numeroAleatorio <= rango.geSuperior()))
                            return rango.getX();
                    }
                    else
                    {
                        if ((numeroAleatorio < rango.geSuperior()))
                            return rango.getX();
                    }
                }

            }
            return 0;
        }

        public static demanda[] ListarangosDemanda()
        {

            demanda[] demanda = new demanda[] {  

            new demanda(0, 0.01, 35)
            ,new demanda(0.01, 0.025, 36)
            ,new demanda(0.025, 0.045, 37)
            ,new demanda(0.045, 0.065, 38)
            ,new demanda(0.065, 0.087, 39)
            ,new demanda(0.087, 0.11, 40)
            ,new demanda(0.11, 0.135, 41)
            ,new demanda(0.135, 0.162, 42)
            ,new demanda(0.162, 0.19, 43)
            ,new demanda(0.19, 0.219, 44)
            ,new demanda(0.219, 0.254, 45)
            ,new demanda(0.254, 0.299, 46)
            ,new demanda(0.299, 0.359, 47)
            ,new demanda(0.359, 0.424, 48)
            ,new demanda(0.424, 0.494, 49)
            ,new demanda(0.494, 0.574, 50)
            ,new demanda(0.574, 0.649, 51)
            ,new demanda(0.649, 0.719, 52)
            ,new demanda(0.719, 0.784, 53)
            ,new demanda(0.784, 0.844, 54)
            ,new demanda(0.844, 0.894, 55)
            ,new demanda(0.894, 0.934, 56)
            ,new demanda(0.934, 0.964, 57)
            ,new demanda(0.964, 0.98, 58)
            ,new demanda(0.98, 0.995, 59)
            ,new demanda(0.995, 1, 60)
            };

            return demanda;
        }

        public static double[] ListaRangosFactorEstacionario() {
            double[] factorEstacionarioMes = new double[]
            {0,1.2,1,0.9,0.8,0.8,0.7,0.8,0.9,1,1.2,1.3,1.4};

            return factorEstacionarioMes;
        }


        
public class tiempoEntrega{
double limiteInferior;
double limiteSuperior;
int x;
    public tiempoEntrega(double limiteInferior,double limiteSuperior,int x){
        this.limiteInferior = limiteInferior;
        this.limiteSuperior = limiteSuperior;
        this.x = x;
        }

    public double getInferior() { return this.limiteInferior; }
    public double geSuperior() { return this.limiteSuperior; }
    public int getX() { return this.x; }

}

        public static int calcularTiempoEntrega(double numAleatorio)
        {
            tiempoEntrega[] lista = new tiempoEntrega[] 
            { new tiempoEntrega(0.00,0.30,1),
            new tiempoEntrega(0.30,0.70,2),
            new tiempoEntrega(0.70,1.00,1)
            };

            int size = lista.Length;
            int index = 0;

            foreach (tiempoEntrega rango in lista)
            {
                index++;

                if ((numAleatorio >= rango.getInferior()))
                {
                    if (index == size)
                    {
                        if ((numAleatorio <= rango.geSuperior()))
                            return rango.getX();
                    }
                    else
                    {
                        if ((numAleatorio < rango.geSuperior()))
                            return rango.getX();
                    }
                }

            }
            return 0;
        }


        public class Costo {

            int ordenar;
            double inventario;
            double faltante;

            public Costo()
            {
                this.ordenar = 0;
                this.inventario = 0;
                this.faltante = 0;
            }

            public Costo(int ordenar, double inventario, double faltante){
                this.ordenar = ordenar;
                this.inventario = inventario;
                this.faltante = faltante;
                }

            public int getOrdenar() { return this.ordenar; }
            public void setOrdenar(int numero) { this.ordenar = numero; }
            public double getInventario() { return this.inventario; }

            public void setInventario(double numero) { this.inventario = numero; }
            public double getFaltante() { return this.faltante; }
            public void setFaltante(double numero) { this.faltante = numero; }


        }

        //----------------SIMULACION---------------------
        public static Costo SimulacionInventario(int q, int r)
        {
            Costo costosDelAno = new Costo();

            /*Agrego la lista de valores de demanda*/
            demanda[] Demanda = ListarangosDemanda();
            double[] numerosAleatorios = listaNumerosAleatorios();
            double[] demandaAjustada = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };     //demandaAjustada.Add(0);
            double[] inventarioInicial = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };   // inventarioInicial.Add(0);
            double[] inventarioFinal = new double[] { 150, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] factorEstacionario = ListaRangosFactorEstacionario();
            int[] faltante = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] orden = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int nroOrden = 0;
            int InvMensProm = 0;
            double sumaInvMensProm = 0;
            double sumaTotalFaltante = 0;

            int x = 0;
            int mesllegadaOrden = 0;
            int faltanteAcumulado = 0;
            bool pedidoRealizado = false;

            for (int i = 1; i <= 12; i++)
            {
                //Console.Write("\nMes " + i + "\n");

                x = valorDemanda(numerosAleatorios[i], Demanda);
                demandaAjustada[i] = Math.Round((x * (factorEstacionario[i])), MidpointRounding.ToEven);



                if (i == mesllegadaOrden)
                {
                    inventarioInicial[i] = q - faltanteAcumulado;
                    faltanteAcumulado = 0;
                    pedidoRealizado = false;
                    mesllegadaOrden = 0;
                }
                else
                {
                    inventarioInicial[i] = inventarioFinal[i - 1];
                }

                inventarioFinal[i] = inventarioInicial[i] - demandaAjustada[i];


                if ((inventarioFinal[i] <= r) && (pedidoRealizado == false))
                {
                    //hago pedido
                    nroOrden++;
                    double numeroAleatorio = numerosAleatorios[12 + nroOrden]; //agarro un nro aleatorio ya generado
                    mesllegadaOrden = i + calcularTiempoEntrega(numeroAleatorio) + 1;
                    pedidoRealizado = true;
                    orden[i] = nroOrden;
                }

                if (inventarioFinal[i] < 0)
                {
                    faltante[i] = (int)Math.Round(Math.Abs(inventarioFinal[i]), MidpointRounding.ToEven); ;
                    inventarioFinal[i] = 0;
                    faltanteAcumulado = faltanteAcumulado + faltante[i];
                }

                if (faltanteAcumulado == 0)
                {
                    InvMensProm = (int)Math.Round(((inventarioInicial[i] + inventarioFinal[i]) / 2), MidpointRounding.ToEven);
                }
                else
                {
                    InvMensProm = (int)Math.Round(((inventarioInicial[i]) / 2) * (inventarioInicial[i] / demandaAjustada[i]), MidpointRounding.ToEven);
                }

                sumaInvMensProm += InvMensProm;
                sumaTotalFaltante += faltanteAcumulado;
                /*
                                Console.Write("Numero Aleatorio:" + numerosAleatorios[i] + "\n");
                                Console.Write("x: " + x + "\n");
                                Console.Write("Factor Estacionario: " + factorEstacionario[i] + "\n");
                                Console.Write("Demanda Ajustada: " + demandaAjustada[i] + "\n");
                                Console.Write("Inventario Inicial: " + inventarioInicial[i] + "\n");
                                Console.Write("Inventario Final: " + inventarioFinal[i] + "\n");
                                Console.Write("Orden: " + orden[i] + "\n");
                                if (mesllegadaOrden != 0)
                                {
                                    Console.Write("Mes de llegada de la Orden: " + mesllegadaOrden + "\n");
                                }
                                Console.Write("Faltante: " + faltante[i] + "\n");

                                Console.Write("Suma acumulada de faltantes: " + sumaTotalFaltante + "\n");
                                Console.Write("Suma acumulada de Inventario mensual Promedio: " + sumaInvMensProm + "\n");

                                Console.Write("-------------------------------");

               

                                Console.ReadKey(); */
            }


            costosDelAno.setOrdenar(calcularCostoPorOrdenar(nroOrden));
            costosDelAno.setInventario(calcularCostoPorInventario(sumaInvMensProm));
            costosDelAno.setFaltante(calcularCostoPorFaltante(sumaTotalFaltante));



            return costosDelAno;
        }

        //Costo por Faltante
        public static double calcularCostoPorFaltante(double sumaTotalFaltante)
        {
            //costo de faltante por unidad
            int costo = 50;
            return sumaTotalFaltante * 50;
        }

        //Costo por inventario
        public static double calcularCostoPorInventario(double sumaInvMensProm)
        {
            //costo de inventario por unidad por ano
            int costo = 20;
            return sumaInvMensProm * (20 / 12);
        }

        //Costo por ordenar
        public static int calcularCostoPorOrdenar(int nroDeOrdenes)
        {
            if (nroDeOrdenes != 0)
            {
                return 100 * nroDeOrdenes;
            }
            else
            {
                return 0;
            }
        }









        public static void simularDiezAnos(int q, int r)
        {
            Costo[] simulacion = new Costo[11];
            double promedioCostoTotal = 0;
            double promedioOrdenarTotal = 0;
            double promedioFaltanteTotal = 0;
            double promedioInventarioTotal = 0;


            for (int i = 1; i <= 10; i++)
            {
                simulacion[i] = SimulacionInventario(q, r);
                Console.Write("\nAño " + (i) + "\n");
                Console.Write("-------------------------------\n");
                promedioCostoTotal += (simulacion[i].getOrdenar() + simulacion[i].getFaltante() + simulacion[i].getInventario());
                Console.Write("Costo Total del ano : " + (simulacion[i].getOrdenar() + simulacion[i].getFaltante() + simulacion[i].getInventario()) + "\n");

                promedioOrdenarTotal += (simulacion[i].getOrdenar());
                Console.Write("Costo Por Ordenar : " + (simulacion[i].getOrdenar()) + "\n");

                promedioFaltanteTotal += (simulacion[i].getFaltante());
                Console.Write("Costo Por Faltante : " + (simulacion[i].getFaltante()) + "\n");

                promedioInventarioTotal += (simulacion[i].getInventario());
                Console.Write("Costo Por Inventario : " + (simulacion[i].getInventario()) + "\n");
                Console.Write("-------------------------------\n\n");
                // System.Threading.Thread.Sleep(10);
            }


            Console.Write("---------------------------------------------\n");
            Console.Write("--------COSTO PROMEDIO DE LOS 10 AÑO---------\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("\nCosto Promedio de 10 años: " + (promedioCostoTotal / 10));
        }





        //----------------FIN SIMULACION---------------------

        static void Main(string[] args)
        {//here
            int q = 300;
            int r = 100;

            simularDiezAnos(q, r);


            Console.ReadKey();
        }//here

        
    }
}
