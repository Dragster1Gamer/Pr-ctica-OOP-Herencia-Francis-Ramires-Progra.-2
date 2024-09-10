/*
Nos dan una escuela. La escuela tiene clases de estudiantes. Cada clase tiene un conjunto de profesores. 
Cada profesor imparte un conjunto de cursos. Los estudiantes tienen un nombre y un número único en la clase. 
Las clases tienen un identificador de texto único. Los profesores tienen nombres. Los cursos tienen nombre, recuento de clases y recuento de ejercicios. 
Tanto los profesores como los estudiantes son personas.

Su tarea es desarrollar las clases (en términos de programación orientada a objetos) junto con sus atributos y operaciones/
*/

public abstract class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    { Nombre = nombre; }

}

public class Estudiante : Persona
{
    public int Numero_Unico { get; set; }

    public Estudiante(string nombre, int numero_unico) : base(nombre)
    {
        Numero_Unico = numero_unico;
    }
}



public class Curso
{
    public string Nombre { get; set; }
    public int NumeroDeClases { get; set; }
    public int NumeroDeEjercicios { get; set; }

    public Curso(string nombre, int numeroDeClases, int numeroDeEjercicios)
    {
        Nombre = nombre;
        NumeroDeClases = numeroDeClases;
        NumeroDeEjercicios = numeroDeEjercicios;
    }
}


public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; }

    public Profesor(string nombre) : base(nombre)
    {
        Cursos = new List<Curso>();
    }

    public void AñadirCurso(Curso curso)
    {
        Cursos.Add(curso);
    }
}



public class Clase
{
    public string Identificador { get; set; }
    public List<Profesor> Profesores { get; set; }
    public List<Estudiante> Estudiantes { get; set; }

    public Clase(string identificador)
    {
        Identificador = identificador;
        Profesores = new List<Profesor>();
        Estudiantes = new List<Estudiante>();
    }

    public void AñadirProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }

    public void AñadirEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }
}


public class Escuela
{
    public List<Clase> Clases { get; set; }

    public Escuela()
    {
        Clases = new List<Clase>();
    }

    public void AñadirClase(Clase clase)
    {
        Clases.Add(clase);
    }
}











public class Program
{
    public static void Main(string[] args)
    {
        // Crear escuela
        Escuela escuela = new Escuela();

        // Crear clase
        Clase clase1 = new Clase("Clase C");

        // Crear estudiantes
        Estudiante estudiante1 = new Estudiante("Wander Smerlin", 1);
        Estudiante estudiante2 = new Estudiante("Smerlin Castillo", 2);

        // Añadir estudiantes a la clase
        clase1.AñadirEstudiante(estudiante1);
        clase1.AñadirEstudiante(estudiante2);

        // Crear profesor
        Profesor profesor1 = new Profesor("Francis Ramirez");

        // Crear cursos
        Curso cursoMatematicas = new Curso("Matemáticas", 10, 50);
        Curso cursoProgramacion = new Curso("Física", 8, 40);

        // Asignar cursos al profesor
        profesor1.AñadirCurso(cursoMatematicas);
        profesor1.AñadirCurso(cursoProgramacion);

        // Añadir profesor a la clase
        clase1.AñadirProfesor(profesor1);

        // Añadir la clase a la escuela
        escuela.AñadirClase(clase1);

        // Mostrar detalles
        Console.WriteLine($"Escuela tiene {escuela.Clases.Count} clase(s)");
        Console.WriteLine($"Clase {clase1.Identificador} tiene {clase1.Estudiantes.Count} estudiante(s) y {clase1.Profesores.Count} profesor(es)");
    }
}
