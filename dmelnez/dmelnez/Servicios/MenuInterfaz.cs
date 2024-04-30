using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Menu encargado de mostrar las opciones principales al usuario.
        /// Recogera la opcion, y la devolvera como parametro.
        /// </summary>
        /// <returns></returns>
        public int menuPrincipal();

        /// <summary>
        /// Menu encargado de mostrar las opciones de aciones sobre la consulta.
        /// Recogera la opcion, y la devolvera como parametro.
        /// </summary>
        /// <returns></returns>
        public int menuConsultas();

        /// <summary>
        /// Menu encargado de mostrar todas las consultas.
        /// Recogera la opcion, y la devolvera como parametro.
        /// </summary>
        /// <returns></returns>
        public int consultasAcciones();




    }
}
