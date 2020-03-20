using System;
namespace Clase2POO
{
    // Clase Person con dos atributos edad y nombre
    public class Person
    {
        // Atributos
        private int age;
        private string name;

        // Propiedades (get y set)
        // Definimos age como propiedad
        public int Age
        {
            // get retorna la edad del objeto. Le podemos meter lógica
            // en este caso si la edad es mayor a 25 le restamos 4.
            get
            {
                if (age <= 25)
                {
                    return age;
                }
                else
                {
                    return age - 4;
                }
            }
            // Set me permite asignar un valor al atributo
            set
            {
                age = value;
            }
        }

        // Constructor vacío
        public Person()
        {
            age = 0;
            name = "Pedro";
        }

        // Constructor con parámetros
        public Person(int age, string inputName)
        {
            this.age = age;
            name = inputName;
        }

        // El atributo name no define propiedad así que usa getters y setters tradicionales.
        public string GetName()
        {
            return name;
        }

        // Nuevamente, podemos asignar lógica dentro de los métodos.
        // Por ejemplo si la edad es mayor que 18 se puede cambiar el nombre, de lo contrario no puede
        public void SetName(string name)
        {
            if (Age > 18)
            {
                this.name = name;
            }
        }
    }
}
