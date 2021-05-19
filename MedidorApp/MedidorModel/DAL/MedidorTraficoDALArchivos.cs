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
    public class MedidorTraficoDALArchivos : IMedidorTraficoDAL
    {
        private string archivo = Directory.GetCurrentDirectory()
        + Path.DirectorySeparatorChar + "medicionTrafico.txt";

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

        public List<MedidorTrafico> GetAll()
        {
            List<MedidorTrafico> lista = new List<MedidorTrafico>();
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
                            string[] textoArray = linea.Split(';');
                            MedidorTrafico mt = new MedidorTrafico()
                            {
                                //NroSerie posicion 0
                                NroSerie = Convert.ToInt32(textoArray[0]),

                                //Fecha posicion 1
                                Fecha = DateTime.ParseExact(textoArray[1], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),

                                //Tipo posicion 2
                                Tipo = Convert.ToInt32(textoArray[2]),

                                //Valor posicion 3
                                Valor = Convert.ToInt32(textoArray[3]),

                                //Estado posicion 4
                                Estado = Convert.ToInt32(textoArray[4])
                            };
                            lista.Add(mt);
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

        public void Save(MedidorTrafico mt)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(mt);
                    writer.Flush();
                }

            }
            catch (IOException ex)
            {

            }
        }
    }
}
