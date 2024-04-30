using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Dtos
{
    internal class PacienteDtos
    {
        string dniPaciente = "aaaaa";

        string nombrePaciente = "aaaaa";

        string apellidos = "aaaaa";

        string especialidad = "aaaaa";

        DateTime fechaCita;

        bool asistenciaCita = false;


        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }

        public PacienteDtos(string dniPaciente, string nombrePaciente, string apellidos, string especialidad, DateTime fechaCita, bool asistenciaCita)
        {
            this.dniPaciente = dniPaciente;
            this.nombrePaciente = nombrePaciente;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistenciaCita = asistenciaCita;
        }

        public PacienteDtos() { }

    }
}
