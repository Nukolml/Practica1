using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno _alumno = new Alumno();
            Profesor _profesor = new Profesor();

            _alumno.Edad = 17;
            _alumno.Nombre = "Nuko";
            _alumno.NoControl = 1021117;

            _profesor.Edad = 23;
            _profesor.Nombre = "Erick";
            _profesor.Sueldo = 1;
            Console.WriteLine("La edad del alumno es:{0} su nombre es {1} y el No. de Control:{2}", _alumno.Edad,_alumno.Nombre,_alumno.NoControl);
            Console.WriteLine("La edad del maestro es:{0} su nombre es {1} y sueldo:{2}", _profesor.Edad, _profesor.Nombre, _profesor.Sueldo);
            Console.ReadKey();

        }
    }
}
