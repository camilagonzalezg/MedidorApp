using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidorModel.DTO;

namespace MedidorModel.DAL
{
    //Se implementa interfaz ILecturaDAL
    public class MedidorTraficoDALArchivos : IMedidorTraficoDAL
    {
        //Patrón Singleton
        //1.Constructor privado
        private MedidorTraficoDALArchivos()
        {

        }

        //2.Atributo estatico de la misma instancia
        private static IMedidorTraficoDAL instancia;

        //3.Metodo estatico que permita obtener la unica instancia
        public static IMedidorTraficoDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidorTraficoDALArchivos();
            return instancia;
        }

        public void Save(MedidorTrafico m)
        {
            throw new NotImplementedException();
        }

        public List<MedidorTrafico> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
