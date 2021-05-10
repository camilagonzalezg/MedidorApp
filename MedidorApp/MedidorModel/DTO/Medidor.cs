using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Medidor
    {
        private int id;
        private DateTime fechaInstalacion;

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

        public DateTime FechaInstalacion
        {
            get
            {
                return fechaInstalacion;
            }

            set
            {
                fechaInstalacion = value;
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
