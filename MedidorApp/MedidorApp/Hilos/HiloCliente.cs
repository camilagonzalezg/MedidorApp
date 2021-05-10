using SocketsUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorApp.Hilos
{
    public class HiloCliente
    {
        private ClienteSocket clienteSocket;

        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }

        public void Ejecutar()
        {

            //1.Primero, preguntar que tipo de medidor es:
            static bool MenuServidor()
                {
                bool continuar = true;
                Console.WriteLine("Ingrese tipo del medidor:");
                Console.WriteLine("0.Medidor Consumo");
                Console.WriteLine("1.Medidor Trafico");
                int opcion = Console.ReadLine().Trim();
                switch (opcion)
                {
                    case "0": IngresarDatosMedidorConsumo();
                        break;
                    case "1": IngresarDatosMedidorTrafico();
                        break;
                    case "3": continuar = false;
                        break;
                }
                return continuar;
            }

            //INGRESAR DATOS MEDIDOR CONSUMO
            static void IngresarDatosMedidorConsumo(){

                //1.Ingresar nro serie medidor consumo
                do
                {
                    Console.WriteLine("Ingrese número de serie del medidor:");
                    nroSerie = Console.ReadLine().Trim();
                } while (nroSerie == string.Empty);

                //2.Ingresar fecha medidor consumo
                do
                {
                    Console.WriteLine("Ingrese fecha:");
                    fecha = Console.ReadLine().Trim();
                } while (fecha == string.Empty);

                //3.Ingresar valor medidor consumo
                do
                {
                    Console.WriteLine("Ingrese valor del medidor:");
                    valor = Console.ReadLine().Trim();
                } while (valor == string.Empty);

                //4.Ingresar estado medidor consumo
                do
                {
                    Console.WriteLine("Ingrese estado del medidor:");
                    estado = Console.ReadLine().Trim();
                } while (estado == string.Empty);

                //Crear objeto medidor consumo
                Medidor m = new Medidor();
                m.NroSerie = nroSerie;
                m.Fecha = fecha;
                m.Tipo = tipo;
                m.Valor = valor;
                m.Estado = estado;

                dal.Save(m);

            }

            //INGRESAR DATOS MEDIDOR TRAFICO
            static void IngresarDatosMedidorTrafico(){

                //1.Ingresar nro serie medidor trafico
                do
                {
                    Console.WriteLine("Ingrese número de serie del medidor de trafico:");
                    nroSerie = Console.ReadLine().Trim();
                } while (nroSerie == string.Empty);

                //2.Ingresar fecha medidor trafico
                do
                {
                    Console.WriteLine("Ingrese fecha:");
                    fecha = Console.ReadLine().Trim();
                } while (fecha == string.Empty);

                //3.Ingresar valor medidor trafico
                do
                {
                    Console.WriteLine("Ingrese valor del medidor:");
                    valor = Console.ReadLine().Trim();
                } while (valor == string.Empty);

                //4.Ingresar estado medidor trafico
                do
                {
                    Console.WriteLine("Ingrese estado del medidor:");
                    estado = Console.ReadLine().Trim();
                } while (estado == string.Empty);

                //Crear objeto medidor trafico
                Medidor m = new Medidor();
                m.NroSerie = nroSerie;
                m.Fecha = fecha;
                m.Tipo = tipo;
                m.Valor = valor;
                m.Estado = estado;

                dal.Save(m);

            }

        }

    }
}
