using MedidorModel.DAL;
using MedidorModel.DTO;
using SocketsUtils;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private ILecturaDAL dalLectura = LecturaDALFactory.CreateDAL();


        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }

        public void Ejecutar()
        {
            //MENU
            clienteSocket.Escribir("Colocar FECHA | NUMERO MEDIDOR | TIPO");

            DateTime fecha;
            int numero;
            int tipo;

            //1.Ingresar fecha medicion
            do
            {
                clienteSocket.Escribir("Ingrese fecha:");
                fecha = DateTime.ParseExact(clienteSocket.Leer(), "yyyy-MM-dd HH:mm:ss",
                CultureInfo.InvariantCulture);

            } while (fecha == null);

            //2.Ingresar numero medidor
            do
            {
                clienteSocket.Escribir("Ingrese numero del medidor:");
                numero = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (numero == null);

            //3.Ingresar tipo medidor consumo
            do
            {
                clienteSocket.Escribir("Ingrese tipo del medidor:");
                clienteSocket.Escribir("1 = Trafico");
                clienteSocket.Escribir("0 = Consumo");
                tipo = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (tipo<0 || tipo>1);

            //Crear objeto lectura
            Lectura l = new Lectura();
            l.Fecha = fecha;
            l.Numero = numero;
            l.Tipo = tipo;

            lock (dalLectura)
            {
                dalLectura.Save(l);
            }
            clienteSocket.CerrarConexion();
        }
    
    }       
}
