using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidorModel.DTO;

namespace MedidorModel.DAL
{

    //Se implementa interfaz ILecturaDAL
    public class MedidorConsumoDALArchivos : IMedidorConsumoDAL
    {
        //Patrón Singleton
        //1.Constructor privado
        private MedidorConsumoDALArchivos()
        {

        }

        //2.Atributo estatico de la misma instancia
        private static IMedidorConsumoDAL instancia;

        //3.Metodo estatico que permita obtener la unica instancia
        public static IMedidorConsumoDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidorConsumoDALArchivos();
            return instancia;
        }

        public void Save(MedidorConsumo m)
        {
            throw new NotImplementedException();
        }

        public List<MedidorConsumo> GetAll()
        {
            throw new NotImplementedException();
        }
    }

}
