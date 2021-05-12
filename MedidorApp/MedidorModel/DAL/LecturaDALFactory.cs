using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    //Factoria de objetos de lectura
    public class LecturaDALFactory
    {
        //Metodo estatico
        public static ILecturaDAL CreateDAL()
        {
            return LecturaDALArchivos.GetInstance();
        }

    }
}
