using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Medidor
    {
        private int nroSerie;
        private DateTime fecha;
        private int tipo;
        private int valor;
        private int estado;

        public int NroSerie
        {
            get
            {
                return nroSerie;
            }

            set
            {
                nroSerie = value;
            }
        }

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

        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public bool enviarLectura()
        {
            //if ()
            //{
                return true;
            //} else {
            //return false;
            //}
        }

    }
}
