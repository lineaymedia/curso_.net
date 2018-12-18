using System;
namespace datos_medicos
{
    public class Informacion_medica : Paciente
    {
        public int altura;
        public int peso;
        public string fumador;
        public string dolencias;

        public Informacion_medica(int altura, int peso, string fumador, string dolencias)
        {
            this.altura = altura;
            this.peso = peso;
            this.fumador = fumador;
            this.dolencias = dolencias;
        }

        public void mostrarDatosMedicos()
        {
            Console.WriteLine("Mostrar datos medicos");

            Console.WriteLine("Altura " + altura);
            Console.WriteLine("Peso " + peso);
            Console.WriteLine("¿Fumador? " + fumador);
            Console.WriteLine("¿Dolencia?" + dolencias);
        }
    }
}
