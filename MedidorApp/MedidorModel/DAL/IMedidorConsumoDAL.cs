using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IMedidorConsumoDAL
    {
        //Metodo guardar mediciones consumo
        void Save(MedidorConsumo m);

        //Listar mediciones consumo
        List<MedidorConsumo> GetAll();
    }
}
