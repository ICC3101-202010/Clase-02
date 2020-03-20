using System;

namespace Clase2POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Persona 1*****\n");

            // Creamos un objetos de la clase Persona llamando al constructor vacío porque no le pasamos ningún parámetro.
            Person p = new Person();
            // Imprimimos sus datos
            Console.WriteLine("Mi nombre es " + p.GetName());
            Console.WriteLine("Tengo " + p.Age + " años");
            // Tratamos de cambiarle el nombre, pero como es menor de edad no nos deja.
            p.SetName("Rodrigo");
            Console.WriteLine("Mi nombre es " + p.GetName());

            Console.WriteLine("\n*****Persona 2*****\n");

            // Creamos un nuevo objeo pero esta vez con edad y nombre asignada por nosotros.
            Person p2 = new Person(30, "Carlos");
            Console.WriteLine("Mi nombre es " + p2.GetName());
            Console.WriteLine("Tengo " + p2.Age + " años");
            // Le cambiamos el nombre, y como es mayor de edad sí nos deja.
            p2.SetName("Rodrigo");
            Console.WriteLine("Mi nuevo nombre es " + p2.GetName());
        }
    }
}
