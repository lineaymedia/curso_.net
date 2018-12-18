using System;

namespace datos_medicos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Datos paciente");

            Paciente paciente = new Paciente("Pedro", "Garcia", "Masculino", 30, "Calle Gran paraiso");

            paciente.DatosPaciente();

            Console.WriteLine("Datos medicos");

            Informacion_medica informacion_medica = new Informacion_medica(172, 90, "No", "Dolor muscular");

            informacion_medica.mostrarDatosMedicos();

        }
    }
}
