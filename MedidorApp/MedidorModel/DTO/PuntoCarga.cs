using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class PuntoCarga
    {
        private int id;
        private int tipo;
        private int capacidadMaxima;
        private DateTime fechaVencimiento;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

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

        public DateTime FechaVencimiento
        {
            get
            {
                return fechaVencimiento;
            }

            set
            {
                fechaVencimiento = value;
            }
        }
    }
}
