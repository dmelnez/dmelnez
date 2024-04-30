using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar al usuario el menu de llegada.
        /// Este metodo, recogera la seleccion del usuario y la devolera el main.
        /// <return>int seleccionMenuPrincipla </return>
        /// </summary>
        /// <returns></returns>
        public int menuPrincipal()
        {

            Console.WriteLine("[0] -> Cerrar Aplicacion.");
            Console.WriteLine("[1] -> Registro de llegada.");
            Console.WriteLine("[2] -> Listado de consultas.");
            int seleccionMenuPrincipla = Convert.ToInt32(Console.ReadLine());

            return seleccionMenuPrincipla;

        }

        public int menuConsultas()
        {
            Console.WriteLine("0.Volver, 1.Mostrar consultas, 2. Imprimir consultas.");
            int seleccionMenuConsultas = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuConsultas;


        }


        public int consultasAcciones()
        {
            Console.WriteLine("0. Psicología, 1.Traumatología, 2.Fisioterapia");

            int seleccionMenuConsultas = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuConsultas;


        }


    }
}
