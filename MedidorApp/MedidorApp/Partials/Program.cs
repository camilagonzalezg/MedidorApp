using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorApp
{
    public partial class Program
    {
        static IMedidorTraficoDAL dalTrafico = MedidorTraficoDALFactory.CreateDAL();
        static IMedidorConsumoDAL dalConsumo = MedidorConsumoDALFactory.CreateDAL();
        static ILecturaDAL dalLectura = LecturaDALFactory.CreateDAL();

        //1.Metodo mostrar medicion de trafico
        static void MostrarLectura()
        {
            List<Lectura> lectura = dalLectura.GetAll();
            lectura.ForEach(l =>
            {
                Console.WriteLine("FECHA:{0} | NUMERO MEDIDOR:{1} | TIPO:{2}",
                l.Fecha,
                l.Numero,
                l.Tipo);
            });

        }



        //Pruebas
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine(" ");
            Console.WriteLine("Presione 1 para mostrar lecturas");
            Console.WriteLine(" ");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    MostrarLectura();
                    break;
            }
            return continuar;
        }

    }
}
