using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class EstacionServicio
    {
        private int capacidadMaxima;

        public int CapacidadMaxima
        {
            get
            {
                return capacidadMaxima;
            }

            set
            {
                capacidadMaxima = value;
            }
        }
    }
}
