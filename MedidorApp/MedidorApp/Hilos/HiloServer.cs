using SocketsUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorApp.Hilos
{
    public class HiloServer
    {
        private int puerto;
        private ServerSocket server;

        public HiloServer(int puerto)
        {
            this.puerto = puerto;
        }

        //Levantar servidor de tipo socket
        public void Ejecutar()
        {
            Console.WriteLine("Iniciando servidor en puerto {0}", puerto);
            this.server = new ServerSocket(puerto);
            if (this.server.Iniciar())
            {
                Console.WriteLine("Servidor iniciado");
                while (true)
                {
                    Console.WriteLine("Esperando Clientes...");
                    ClienteSocket cliente = this.server.ObtenerCliente();
                    //Crear una instancia del hilo del Cliente

                }
            }

        }

    }
}
