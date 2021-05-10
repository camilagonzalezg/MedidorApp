using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class ZonaHoraria
    {
        private string codigo;
        private string nombreLargo;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string NombreLargo
        {
            get
            {
                return nombreLargo;
            }

            set
            {
                nombreLargo = value;
            }
        }
    }
}
