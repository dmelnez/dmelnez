using dmelnez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// Metodo cargado de abrir el fichero. Leerlo y volcar cada una de las lineas y posiciones del mismo, en las listas.
        /// </summary>
        /// <param name="listaPacientes"></param>
        public void cargaInicial(List<PacienteDtos> listaPacientes);

    }
}
