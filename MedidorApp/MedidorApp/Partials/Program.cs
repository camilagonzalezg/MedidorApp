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
        static IMedidorTraficoDAL dal = MedidorTraficoDALFactory.CreateDAL();

        //1.Metodo mostrar medidores
        static void MostrarMedidores()
        {
            List<MedidorTrafico> medidortrafico = dal.GetAll();
            medidortrafico.ForEach(l =>
            {
                Console.WriteLine("NroSerie:{0} | Fecha:{1} | Tipo:{2} | Valor:{3} | Estado:{4}",
                l.NroSerie,
                l.Fecha,
                l.Tipo,
                l.Valor,
                l.Estado);
            });
        }

        //3.Menu
        static bool Menu()
        {
            bool continuar = true;
            //Console.WriteLine("Presione 1 para ver mensajes");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    MostrarMedidores();
                    break;
            }
            return continuar;
        }

    }
}
