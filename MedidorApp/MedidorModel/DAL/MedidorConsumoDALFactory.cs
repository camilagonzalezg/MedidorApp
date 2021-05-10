using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorConsumoDALFactory
    {
        //Metodo estatico
        public static IMedidorConsumoDAL CreateDAL()
        {
            return MedidorConsumoDALArchivos.GetInstance();
        }

    }
}
