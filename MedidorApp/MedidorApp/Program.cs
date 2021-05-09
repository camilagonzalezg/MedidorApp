using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorApp
{
    class Program
    {

        //1.Probaremos con una lectura de prueba
        static ILecturaDAL dal = LecturaDALFactory.CreateDAL();
        static void Main(string[] args)
        {

            //2. Probaremos con una lectura de prueba
            Lectura l = new Lectura()
            {
                Fecha = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"),
                Valor = "123",
                Tipo = 1,
                UnidadMedida = "123"
            };
            dal.Save(l);

        }
    }
}
