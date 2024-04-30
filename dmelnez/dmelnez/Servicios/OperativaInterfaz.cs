using dmelnez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de solicitar al cliente su dni. Y validarlo.
        /// </summary>
        public void registroLlegada(List<PacienteDtos>listaPacientes);

        /// <summary>
        /// Metodo encargado de Mostrar cada una de las consultas existentes.
        /// </summary>
        public void listadoConsultas(List<PacienteDtos> listaPacientes);


    }
}
