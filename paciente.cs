using System;
namespace datos_medicos
{
    public class Paciente
    {
        public string nombre;
        public string apellidos;
        public string sexo;
        private int edad;
        private string direccion;

        public Paciente(string nombre, string apellidos, string sexo, int edad, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.edad = edad;
            this.direccion = direccion;
        }

        public void DatosPaciente()
        {
            Console.WriteLine("Datos paciente");

            Console.WriteLine("Nombre " + nombre);
            Console.WriteLine("Apellidos " + apellidos);
            Console.WriteLine("Sexo " + sexo);
            Console.WriteLine("Edad " + edad);
            Console.WriteLine("Dirección " + direccion);
        }
    }
}
