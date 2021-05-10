using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorTraficoDALFactory
    {

        //Metodo estatico
        public static IMedidorTraficoDAL CreateDAL()
        {
            return MedidorTraficoDALArchivos.GetInstance();
        }

    }
}
