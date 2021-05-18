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

        //1.Metodo mostrar medicion de trafico
        static void MostrarMedidorTrafico()
        {
            List<MedidorTrafico> medidorTrafico = dalTrafico.GetAll();
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

        //1.Metodo mostrar medicion de consumo
        static void MostrarMedidorConsumo()
        {
            List<MedidorConsumo> medidorConsumo = dalConsumo.GetAll();
            medidorConsumo.ForEach(mc =>
            {
                Console.WriteLine("NroSerie:{0} | Fecha:{1} | Tipo:{2} | Valor:{3} | Estado:{4}",
                mc.NroSerie,
                mc.Fecha,
                mc.Tipo,
                mc.Valor,
                mc.Estado);
            });
        }

        //3.Menu
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Mostrar Mediciones:");
            Console.WriteLine("0: Medicion Consumo");
            Console.WriteLine("1: Medicion Trafico");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "0":
                    MostrarMedidorTrafico();
                    break;
                case "1":
                    MostrarMedidorConsumo();
                    break;
            }
            return continuar;
        }

    }
}
