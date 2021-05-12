using MedidorModel.DAL;
using MedidorModel.DTO;
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
        private IMedidorConsumoDAL dalMedidorConsumo = MedidorConsumoDALFactory.CreateDAL();
        private IMedidorTraficoDAL dalMedidorTrafico = MedidorTraficoDALFactory.CreateDAL();

        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }

        public void Ejecutar()
        {
            //MENU
            Console.WriteLine("*****MEDIDOR APP*****");
            Console.WriteLine("Ingrese tipo del medidor:");
            Console.WriteLine("0 = Medidor Consumo");
            Console.WriteLine("1 = Medidor Trafico");
            string opcion = clienteSocket.Leer().Trim();

            switch (opcion)
            {
                case "0":
                    IngresarDatosMedidorConsumo();
                    break;
                case "1":
                    IngresarDatosMedidorTrafico();
                    break;
            }
        }

        //INGRESAR DATOS MEDIDOR CONSUMO
        public void IngresarDatosMedidorConsumo()
        {
            int nroSerie;
            DateTime fecha;
            int tipo;
            int valor;
            int estado;

            //1.Ingresar nro serie medidor consumo
            do
            {
                clienteSocket.Escribir("Ingrese número de serie del medidor de consumo:");
                nroSerie = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (nroSerie == null);

            //2.Ingresar fecha medidor consumo
            do
            {
                clienteSocket.Escribir("Ingrese fecha:");
                fecha = Convert.ToDateTime(clienteSocket.Leer().Trim());
            } while (fecha == null);

            //3.Ingresar tipo medidor consumo
            tipo = 0;

            //4.Ingresar valor medidor consumo
            do
            {
                clienteSocket.Escribir("Ingrese valor del medidor de consumo:");
                valor = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (valor == null);

            //5.Ingresar estado medidor consumo
            do
            {
                clienteSocket.Escribir("Ingrese estado del medidor de consumo:");
                clienteSocket.Escribir("-1 = Error de lectura");
                clienteSocket.Escribir("0 = OK");
                clienteSocket.Escribir("1 = Punto de Carga lleno");
                clienteSocket.Escribir("2 = Requiere Mantención preventiva");
                estado = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (estado <-1 || estado > 2);

            //Crear objeto medidor consumo
            MedidorConsumo mc = new MedidorConsumo();
            mc.NroSerie = nroSerie;
            mc.Fecha = fecha;
            mc.Tipo = tipo;
            mc.Valor = valor;
            mc.Estado = estado;

            lock (dalMedidorConsumo)
            {
                dalMedidorConsumo.Save(mc);
            }
            clienteSocket.CerrarConexion();
        }


        //INGRESAR DATOS MEDIDOR TRAFICO
        public void IngresarDatosMedidorTrafico()
        {
            int nroSerie;
            DateTime fecha;
            int tipo;
            int valor;
            int estado;

            //1.Ingresar nro serie medidor trafico
            do
            {
                clienteSocket.Escribir("Ingrese número de serie del medidor de trafico:");
                nroSerie = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (nroSerie == null);

            //2.Ingresar fecha medidor trafico
            do
            {
                clienteSocket.Escribir("Ingrese fecha:");
                fecha = Convert.ToDateTime(clienteSocket.Leer().Trim());
            } while (fecha == null);

            //3.Ingresar tipo medidor trafico
            tipo = 1;

            //3.Ingresar valor medidor trafico
            do
            {
                clienteSocket.Escribir("Ingrese valor del medidor de trafico:");
                valor = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (valor == null);

            //4.Ingresar estado medidor trafico
            do
            {
                clienteSocket.Escribir("Ingrese estado del medidor de trafico:");
                clienteSocket.Escribir("-1 = Error de lectura");
                clienteSocket.Escribir("0 = OK");
                clienteSocket.Escribir("1 = Punto de Carga lleno");
                clienteSocket.Escribir("2 = Requiere Mantención preventiva");
                estado = Convert.ToInt32(clienteSocket.Leer().Trim());

            } while (estado < -1 && estado > 2);

            //Crear objeto medidor trafico
            MedidorTrafico mt = new MedidorTrafico();
            mt.NroSerie = nroSerie;
            mt.Fecha = fecha;
            mt.Tipo = tipo;
            mt.Valor = valor;
            mt.Estado = estado;

            lock (dalMedidorTrafico)
            {
                dalMedidorTrafico.Save(mt);
            }
            clienteSocket.CerrarConexion();
        }

        


    }       
}
