using dmelnez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal class FicherosImplementacion : FicherosInterfaz
    {
        /// <summary>
        /// Metodo cargado de abrir el fichero. Leerlo y volcar cada una de las lineas y posiciones del mismo, en las listas.
        /// </summary>
        /// <param name="listaPacientes"></param>
        public void cargaInicial(List<PacienteDtos> listaPacientes)
        {
            string rutaFichero = "C:\\Users\\dmelnez\\Desktop\\citas.txt";

            string[] lineasFihero = File.ReadAllLines(rutaFichero);

            try
            {

                for (int i = 0; i < lineasFihero.Length; i++)
                {
                    PacienteDtos nuevoPaciente = new PacienteDtos();

                    string[] arraySeparado = lineasFihero[i].Split(";");
                    nuevoPaciente.DniPaciente = arraySeparado[0];

                    nuevoPaciente.NombrePaciente = arraySeparado[1];

                    nuevoPaciente.Apellidos = arraySeparado[2];

                    nuevoPaciente.Especialidad = arraySeparado[3];

                    nuevoPaciente.FechaCita = Convert.ToDateTime(arraySeparado[4]);

                    nuevoPaciente.AsistenciaCita = Convert.ToBoolean(arraySeparado[5]);

                    listaPacientes.Add(nuevoPaciente);



                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }



        }
 


    }
}
