using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicPSOLID
{
    public class StudentFactory
    {
        public Student CreateStudent()
        {
            Console.Write("Ingrese el ID del estudiante: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre: ");
            string firstName = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            string lastName = Console.ReadLine();
            Console.Write("Ingrese el correo: ");
            string email = Console.ReadLine();
            Console.Write("Ingrese la fecha de nacimiento (yyyy-MM-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            var address = new Address
            {
                Address1 = "Dirección 1",
                Address2 = "Dirección 2",
                City = "Ciudad",
                State = "Estado",
                Zipcode = "Código Postal"
            };

            return new Student(id, firstName, lastName, dob, email, address);
        }
    }

}
