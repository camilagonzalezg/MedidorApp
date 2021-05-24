using MedidorApp.Hilos;
using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedidorApp
{
    public partial class Program
    {
        static IMedidorTraficoDAL dal1 = MedidorTraficoDALFactory.CreateDAL();
        static IMedidorConsumoDAL dal2 = MedidorConsumoDALFactory.CreateDAL();
       
        static void Main(string[] args)
        {
            //Crear medicion de trafico estatico
            DateTime fechaTrafico = new DateTime(2020, 10, 10, 10, 10, 10);
            MedidorTrafico mt1 = new MedidorTrafico()
            {
                NroSerie = 1234,
                Fecha = fechaTrafico,
                Tipo = 1,
                Valor = 1234,
                Estado = -1
            };
            dal1.Save(mt1);

            //Crear medicion de consumo estatico
            DateTime fechaConsumo = new DateTime(2020, 10, 11, 10, 10, 10);
            MedidorConsumo mc1 = new MedidorConsumo()
            {
                NroSerie = 5678,
                Fecha = fechaConsumo,
                Tipo = 0,
                Valor = 5678,
                Estado = 1
            };
            dal2.Save(mc1);

            Console.WriteLine(" ");
            Console.WriteLine("(Mediciones Creadas - Iniciando hilo del Server)");
            int puerto = int.Parse(ConfigurationManager.AppSettings["puerto"]);
            HiloServer hiloServer = new HiloServer(puerto);
            Thread t = new Thread(new ThreadStart(hiloServer.Ejecutar));

            //Cambiamo prioridad
            t.IsBackground = true;

            t.Start();
            while (Menu());
        }

        }
    }

