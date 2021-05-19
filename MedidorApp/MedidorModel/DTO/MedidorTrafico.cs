using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class MedidorTrafico: Medidor
    {

        public void obtenerCantVehiculos(int v)
        {

        }

        public override string ToString()
        {
            return NroSerie + ";" + Fecha + ";" + Tipo + ";" + Valor + ";" + Estado;
        }

    }
}
