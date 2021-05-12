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
        static void MostrarMedidorTrafico()
        {
            List<MedidorTrafico> medidorTrafico = dal.GetAll();
            medidorTrafico.ForEach(mt =>
            {
                Console.WriteLine("NroSerie:{0} | Fecha:{1} | Tipo:{2} | Valor:{3} | Estado:{4}",
                mt.NroSerie,
                mt.Fecha,
                mt.Tipo,
                mt.Valor,
                mt.Estado);
            });
        }

        //3.Menu
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Presione x para ver mensajes");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "x":
                    MostrarMedidorTrafico();
                    break;
            }
            return continuar;
        }

    }
}
