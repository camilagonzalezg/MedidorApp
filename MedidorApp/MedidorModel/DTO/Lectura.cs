using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Lectura
    {

        private DateTime fecha;
        //private string valor;
        private int numero;
        private int tipo;
        //private string unidadMedida;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        //public string Valor
        //{
        //    get
        //    {
        //        return valor;
        //    }

        //    set
        //    {
        //        valor = value;
        //    }
        //}

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
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

        //public string UnidadMedida
        //{
        //    get
        //    {
        //        return unidadMedida;
        //    }

        //    set
        //    {
        //        unidadMedida = value;
        //    }
        //}

        public override string ToString()
        {
            return Fecha + ";" + Numero + ";" + Tipo;
        }

    }
}
