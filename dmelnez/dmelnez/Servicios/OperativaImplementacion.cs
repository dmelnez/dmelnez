using dmelnez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de solicitar al cliente su dni. Y validarlo.
        /// </summary>
        public void registroLlegada(List<PacienteDtos> listaPacientes)
        {
            bool esValido = false;
          
            do
            {
                Console.WriteLine("Introduce su dni: ");
                int numeroDNI = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Letra del DNI: ");
                char letraDNI = Convert.ToChar(Console.ReadLine());

                esValido =  validadorDNI(numeroDNI, letraDNI);

                string dniCompleto = numeroDNI.ToString() + letraDNI;

                DateTime hoy = DateTime.Today;

                foreach(var Paciente in listaPacientes)
                {

                    if(Paciente.DniPaciente.Equals(dniCompleto) && Paciente.Especialidad != null && Paciente.FechaCita.Equals(hoy))
                    {

                        Console.WriteLine("Espere su turno para la consulta de" + Paciente.Especialidad + "en la sala de espera. Su especialista le avisará.\r\n");

                    }

                   

                }

                

            }

            while (!esValido);




        }


        /// <summary>
        /// Metodo encargado de validar la letra del DNI.
        /// </summary>
        private bool validadorDNI(int numeroDNI, char letraDNI)
        {
            char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
           
            bool esValidado = true;

            int calculoDNI = numeroDNI % 23 ;


            if (letrasDNI[calculoDNI].Equals(letrasDNI))
            {

                esValidado = false;

            }

            else
            {

                esValidado = true;
            }


            return esValidado;

        }


        /// <summary>
        /// Metodo encargado de Mostrar cada una de las consultas existentes.
        /// </summary>
        public void listadoConsultas(List<PacienteDtos> listaPacientes)
        {

            MenuInterfaz me = new MenuImplementacion();

            int seleccionConsultas = me.menuConsultas();

            bool esCerrarMenu = false;

            do
            {
                switch (seleccionConsultas)
                {
                    case 0:
                        esCerrarMenu = true;
                    break;

                    case 1:
                        Console.WriteLine("Mostrar consultas: ");
                        mostrarConsultas(listaPacientes);
                    break;

                    case 2:
                        Console.WriteLine("Imprimir Consultas");
                        imprimirConsultas(listaPacientes);
                    break;

                    default:
                        Console.WriteLine("SELECCION NO VALIDA");
                    break;

                }
            }

            while (!esCerrarMenu);

         



        }


        /// <summary>
        /// Metodo encargado de solicitar una fecha especifica, y en funcion a la consulta y fecha. Muestra al usuario todas las citas disponible en base a esos datos.
        /// </summary>
        private void mostrarConsultas(List<PacienteDtos> listaPacientes)
        {
            MenuInterfaz me = new MenuImplementacion();

            int seleccionMenuAcciones = me.consultasAcciones();

            Console.WriteLine("Introduzca la fecha: (dd-MM-yyyy)");
            DateTime fechaEspecifica = Convert.ToDateTime(Console.ReadLine());


            switch (seleccionMenuAcciones)
            {
                case 0:
                    Console.WriteLine("Pisicologia");
                    string consulta01 = "Pisicologia";

                    foreach (var pacientes in listaPacientes)
                    {
                      if(pacientes.Especialidad.Equals(consulta01) && pacientes.FechaCita.Equals(fechaEspecifica))
                        {
                            Console.WriteLine("Nombre Completo: ".Concat(pacientes.NombrePaciente).Concat(pacientes.Apellidos));
                        }

                    }

                break;

                case 1:
                    Console.WriteLine("Traumatologia");
                    string consulta02 = "Traumatologia";

                    foreach (var pacientes in listaPacientes)
                    {
                        if (pacientes.Especialidad.Equals(consulta02) && pacientes.FechaCita.Equals(fechaEspecifica))
                        {
                            Console.WriteLine("Nombre Completo: ".Concat(pacientes.NombrePaciente).Concat(pacientes.Apellidos));
                        }

                    }

                    break;

                case 2:
                    Console.WriteLine("Fisioterapia");
                    string consulta03 = "Fisioterapia";


                    foreach (var pacientes in listaPacientes)
                    {
                        if (pacientes.Especialidad.Equals(consulta03) && pacientes.FechaCita.Equals(fechaEspecifica))
                        {
                            Console.WriteLine("Nombre Completo: ".Concat(pacientes.NombrePaciente).Concat(pacientes.Apellidos));
                        }

                    }

                    break;

                default:
                    Console.WriteLine("SELECCION NO VALIDA");
                 break;

            }



        }

        /// <summary>
        /// Metodo encargado de imprimir en un fichero, todas las citas especificadas para un dia concreto.
        /// </summary>
        /// <param name="listaPacientes"></param>
        private void imprimirConsultas(List<PacienteDtos> listaPacientes)
        {
            MenuInterfaz me = new MenuImplementacion();

            int seleccionMenuAcciones = me.consultasAcciones();

            Console.WriteLine("Introduzca la fecha: (dd-MM-yyyy)");
            DateTime fechaSeleccionada = Convert.ToDateTime(Console.ReadLine());

            string rutaAsistencias = "C:\\Users\\dmelnez\\Desktop\\Asistencia" + fechaSeleccionada.ToString("dd-MM-yyyy") +".txt";


            switch (seleccionMenuAcciones)
            {
                case 0:
                    Console.WriteLine("Pisicologia");
                    string Pisicologia = "Psicología";

                    try
                    {

                        using (StreamWriter sw = new StreamWriter(rutaAsistencias))
                        {

                            foreach (var pacientes in listaPacientes)
                            {

                                if (pacientes.AsistenciaCita == true && pacientes.Especialidad.Equals(Pisicologia) && pacientes.FechaCita.Equals(fechaSeleccionada))
                                {
                                    sw.WriteLine("Nombre Completo: " + pacientes.NombrePaciente + ":" + pacientes.Apellidos + " " + pacientes.FechaCita);

                                }




                            }
                        }
                    }

                    catch (IOException io)
                    {

                        throw;

                    }


                    break;

                case 1:
                    Console.WriteLine("Traumatologia");
                    string Traumatologia = "Traumatologia";

                    try {

                        using (StreamWriter sw = new StreamWriter(rutaAsistencias))
                        {

                            foreach (var pacientes in listaPacientes)
                            {

                                if (pacientes.AsistenciaCita == true && pacientes.Especialidad.Equals(Traumatologia) && pacientes.FechaCita.Equals(fechaSeleccionada))
                                {
                                    sw.WriteLine("Nombre Completo: " + pacientes.NombrePaciente + ":" + pacientes.Apellidos + " " + pacientes.FechaCita);

                                }

                            }


                        }
                    }

                    catch (IOException io)
                    {

                        throw;

                    }


                    break;

                case 2:
                    Console.WriteLine("Fisioterapia");
                    string Fisioterapia = "Fisioterapia";

                    try { 

                    using (StreamWriter sw = new StreamWriter(rutaAsistencias))
                    {

                        foreach (var pacientes in listaPacientes)
                        {

                            if (pacientes.AsistenciaCita == true && pacientes.Especialidad.Equals(Fisioterapia) && pacientes.FechaCita.Equals(fechaSeleccionada))
                            {
                                sw.WriteLine("Nombre Completo: " + pacientes.NombrePaciente + ":" + pacientes.Apellidos + " " + pacientes.FechaCita);

                            }

                        }


                    }
                    }

                    catch (IOException io)
                    {



                        throw;

                    }


                    break;

                default:
                    Console.WriteLine("SELECCION NO VALIDA");
                    break;
            }

        }



    }
}
