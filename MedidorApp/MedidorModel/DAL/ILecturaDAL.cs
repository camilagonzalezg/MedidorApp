using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface ILecturaDAL
    {
        //Metodo guardar lecturas
        void Save(Lectura l);

        //Listar lecturas
        List<Lectura> GetAll();
    }
}
