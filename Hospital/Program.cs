using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();
            Hombre hombre = new Hombre();

            Persona persona = new Persona();
            persona.id = 1;
            persona.posicion = "Paciente";
            persona.sexo = "hombre";
            persona.name = "roberto";
            persona.fecha_de_nacimiento = "15/12/04";
            paciente.TipoPaciente = "afiliado";
            hombre.enfermedades_de_hombre = "enfermedad en la prostata";
            
            Console.ReadKey();
            

            Enfermera enfermera = new Enfermera();
            persona.id = 2;
            persona.posicion = "enfermera";
            persona.sexo = "mujer";
            persona.name = "alejandra";
            persona.fecha_de_nacimiento = "12/11/01";
            enfermera.tipo_de_enfermera = "interna";
            Console.ReadKey();

            Medico medico = new Medico();
            persona.id = 3;
            persona.posicion = "medico";
            persona.sexo = "hombre";
            persona.name = "juan";
            persona.fecha_de_nacimiento = "15/12/89";
            medico.tipo_de_medico = "aprendiz";

            Cirujano cirujano = new Cirujano();
            persona.id =4;
            persona.posicion = "Medico cirujano";
            persona.sexo = "hombre";
            persona.name = "manuel";
            persona.fecha_de_nacimiento = "25/08/99";
            medico.tipo_de_medico  ="interno";
            cirujano.tipo_de_cirujano = "cirujano cardiatico";
        }
    }
}
