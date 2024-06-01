using System;

namespace ConsoleApp1
{
    // Clase base que representa a un miembro de la comunidad
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }

        public MiembroDeLaComunidad(string nombre, string identificacion)
        {
            Nombre = nombre;
            Identificacion = identificacion;
        }

        // Método virtual que puede ser sobrescrito por clases derivadas
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Identificación: {Identificacion}");
        }
    }

    // Clase derivada de MiembroDeLaComunidad
    public class Empleado : MiembroDeLaComunidad
    {
        public Empleado(string nombre, string identificacion)
            : base(nombre, identificacion)
        {
        }
    }

    // Clase derivada de MiembroDeLaComunidad
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, string identificacion, string carrera)
            : base(nombre, identificacion)
        {
            Carrera = carrera;
        }

        // Sobrescribe el método MostrarInformacion para incluir la carrera
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    // Clase derivada de MiembroDeLaComunidad
    public class ExAlumno : MiembroDeLaComunidad
    {
        public string AñoGraduacion { get; set; }

        public ExAlumno(string nombre, string identificacion, string añoGraduacion)
            : base(nombre, identificacion)
        {
            AñoGraduacion = añoGraduacion;
        }

        // Sobrescribe el método MostrarInformacion para incluir el año de graduación
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }

    // Clase derivada de Empleado
    public class Docente : Empleado
    {
        public Docente(string nombre, string identificacion)
            : base(nombre, identificacion)
        {
        }
    }

    // Clase derivada de Empleado
    public class Administrativo : Empleado
    {
        public Administrativo(string nombre, string identificacion)
            : base(nombre, identificacion)
        {
        }
    }

    // Clase derivada de Docente
    public class Administrador : Docente
    {
        public Administrador(string nombre, string identificacion)
            : base(nombre, identificacion)
        {
        }
    }

    // Clase derivada de Docente
    public class Maestro : Docente
    {
        public Maestro(string nombre, string identificacion)
            : base(nombre, identificacion)
        {
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de varias clases y mostrar su información
            MiembroDeLaComunidad estudiante = new Estudiante("Daniel De Leon", "346178", "Programacion");
            MiembroDeLaComunidad exAlumno = new ExAlumno("Rebeca Thomas", "940217", "2018");
            MiembroDeLaComunidad maestro = new Maestro("Jhon Hidalgo", "642393");

            estudiante.MostrarInformacion();
            exAlumno.MostrarInformacion();
            maestro.MostrarInformacion();
        }
    }
}
