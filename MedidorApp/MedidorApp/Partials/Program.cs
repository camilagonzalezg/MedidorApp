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
        static ILecturaDAL dal = LecturaDALFactory.CreateDAL();

        //1.Metodo ingresar lectura
        static void IngresarLectura()
        {

        }

        //2.Metodo mostrar lectura
        static void MostrarLecturas()
        {
            List<Lectura> lecturas = dal.GetAll();
            lecturas.ForEach(l =>
            {
                Console.WriteLine("Fecha:{0} | Valor:{1} | Tipo:{2} | Unidad Medida:{3}",
                l.Fecha,
                l.Valor,
                l.Tipo,
                l.UnidadMedida);
            });
        }

        //3.Menu
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("*****MEDIDOR APP*****");
            Console.WriteLine("Recibiendo lectura de clientes (fecha | nro_medidor | tipo)");
            Console.WriteLine("...");
            return continuar;
        }

    }
}
