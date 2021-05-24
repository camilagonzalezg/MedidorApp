using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidorModel.DTO;
using System.IO;
using System.Globalization;

namespace MedidorModel.DAL
{
    //Se implementa interfaz ILecturaDAL
    public class LecturaDALArchivos : ILecturaDAL
    {
        //En orden de crear un archivo de salida, hay que crear donde irá el 
        //archivo
        private string archivo = Directory.GetCurrentDirectory()
        + Path.DirectorySeparatorChar + "lectura.txt";


        //Patrón Singleton
        //1.Constructor privado
        private LecturaDALArchivos()
        {

        }

        //2.Atributo estatico de la misma instancia
        private static ILecturaDAL instancia;

        //3.Metodo estatico que permita obtener la unica instancia
        public static ILecturaDAL GetInstance()
        {
            if (instancia == null)
                instancia = new LecturaDALArchivos();
            return instancia;
        }

        //Metodo obtener
        public List<Lectura> GetAll()
        {
            List<Lectura> lista = new List<Lectura>();
            //Puede fallar la estructura del archivo, usamos trycatch
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    //Lectura de texto línea a línea,
                    //mientras el texto sea diferente de null
                    string linea = null;
                    do
                    {
                        //indicamos que lea la linea
                        linea = reader.ReadLine();
                        //que se ejecute mientras linea =! nulo
                        if (linea != null)
                        {
                            //En la lectura, leer la separacion 
                            string[] textoArray = linea.Split('|');

                            Lectura l = new Lectura()
                            {
                                //Fecha posicion 0
                                Fecha = DateTime.ParseExact(textoArray[0], "dd-MM-yyyy HH:mm:ss", 
                                CultureInfo.InvariantCulture),

                                //Numero posicion 1
                                Numero = Convert.ToInt32(textoArray[1]),

                                //Tipo posicion 2
                                Tipo = Convert.ToInt32(textoArray[2]),

                            };
                        lista.Add(l);
                        }
                    } while (linea != null);
                }
            }catch (IOException ex)
            {
                lista = null;
            }
            return lista;
        }

        //Metodo guardar
        public void Save(Lectura l)
        {
            try
            {
                //Creamos using para que pueda cerrar la conexion
                using(StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(l);
                    writer.Flush();
                }
            } catch (IOException ex)
            {
                
            }
        }

    }
}
