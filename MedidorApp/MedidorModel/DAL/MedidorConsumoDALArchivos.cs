using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidorModel.DTO;
using System.Globalization;

namespace MedidorModel.DAL
{

    //Se implementa interfaz ILecturaDAL
    public class MedidorConsumoDALArchivos : IMedidorConsumoDAL
    {
        private string archivo = Directory.GetCurrentDirectory()
        + Path.DirectorySeparatorChar + "medicionConsumo.txt";

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

        public void Save(MedidorConsumo mc)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(mc);
                    writer.Flush();
                }

            }
            catch (IOException ex)
            {

            }
        }

        public List<MedidorConsumo> GetAll()
        {
            List<MedidorConsumo> lista = new List<MedidorConsumo>();
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string linea = null;
                    do
                    {
                        linea = reader.ReadLine();
                        if (linea != null)
                        {
                            string[] textoArray = linea.Split('-');
                            MedidorConsumo mc = new MedidorConsumo()
                            {
                                //NroSerie posicion 0
                                NroSerie = Convert.ToInt32(textoArray[0]),

                                //Fecha posicion 1
                                Fecha = Convert.ToDateTime(textoArray[1], CultureInfo.InvariantCulture),

                                //Tipo posicion 3
                                Tipo = Convert.ToInt32(textoArray[2]),

                                //Valor posicion 4
                                Valor = Convert.ToInt32(textoArray[3]),

                                //Estado posicion 5
                                Estado = Convert.ToInt32(textoArray[4])
                            };
                            lista.Add(mc);
                        }

                    } while (linea != null);
                }
            }
            catch (IOException ex)
            {
                lista = null;
            }
            return lista;
        }
    }

}
