using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;

namespace Pulsacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            Persona persona = new Persona();
            PersonaService personaService = new PersonaService();
            Console.WriteLine("Digite su edad: ");
            persona.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su nombre: ");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Digite su sexo: ");
            persona.Sexo = Console.ReadLine();
            Console.WriteLine("Digite su identificacion: ");
            persona.Identificacion = Console.ReadLine();
            personaService.calcularPulsacion(persona);
           Console.WriteLine("Su pulsacion es: "+ persona.Pulsacion);
            mensaje = personaService.Guardar(persona);
            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
    }
}
