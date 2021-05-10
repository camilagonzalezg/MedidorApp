using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IMedidorTraficoDAL
    {
        //Metodo guardar mediciones trafico
        void Save(MedidorTrafico m);

        //Listar mediciones trafico
        List<MedidorTrafico> GetAll();

    }
}
