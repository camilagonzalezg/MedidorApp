using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Direccion
    {
        private int codPostal;
        private string detalle;
        private int nro;
        private string adicional;

        public int CodPostal
        {
            get
            {
                return codPostal;
            }

            set
            {
                codPostal = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public int Nro
        {
            get
            {
                return nro;
            }

            set
            {
                nro = value;
            }
        }

        public string Adicional
        {
            get
            {
                return adicional;
            }

            set
            {
                adicional = value;
            }
        }
    }
}
