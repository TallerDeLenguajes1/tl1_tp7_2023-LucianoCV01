using EspacioEmpleado;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Empleado persona1 = new("Luis", "Gonzales", new(2000, 7, 12), 's', 'm', new(2018, 10, 22), 45000, cargos.Auxiliar);
        Empleado persona2 = new("Catalina", "Torres", new(1997, 12, 4), 'c', 'f', new(2009, 3, 3), 95000, cargos.Especialista);
        Empleado persona3 = new("Carlos", "Cruz", new(1990, 2, 5), 'c', 'm', new(2008, 6, 13), 65000, cargos.Ingeniero);

        double totalSalarios = persona1.Salario(persona1.CalcularAntigüedad()) + persona2.Salario(persona2.CalcularAntigüedad()) + persona3.Salario(persona3.CalcularAntigüedad());
        Console.WriteLine("Monto total: $ " + totalSalarios);

        int jubilacion1 = persona1.CalcularJubilacion(persona1.CalcularEdad());
        int jubilacion2 = persona2.CalcularJubilacion(persona2.CalcularEdad());
        int jubilacion3 = persona3.CalcularJubilacion(persona3.CalcularEdad());

        if (jubilacion1 <= jubilacion2 && jubilacion1 <= jubilacion3)
        {
            mostrarDatos(persona1);
        } else
        {
            if (jubilacion2 <= jubilacion1 && jubilacion2 <= jubilacion3)
            {
                mostrarDatos(persona2);
            } else
            {
                mostrarDatos(persona3);
            }
        }
    }
    public static void mostrarDatos(Empleado persona)
    {
        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Apellido: " + persona.Apellido);
        Console.WriteLine("Fecha de Nacimiento: " + persona.FechaNacimiento);
        Console.WriteLine("Estado civil: " + persona.EstadoCivil);
        Console.WriteLine("Genero: " + persona.Genero);
        Console.WriteLine("Fecha de Ingreso: " + persona.FechaIngreso);
        Console.WriteLine("Sueldo Basico: $" + persona.SueldoBasico);
        Console.WriteLine("Cargo: " + persona.Cargo);
        int antiguedad = persona.CalcularAntigüedad();
        Console.WriteLine("Antiguedad: " + antiguedad);
        int edad = persona.CalcularEdad();
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Jubilacion: " + persona.CalcularJubilacion(edad));
        Console.WriteLine("Salario: $" + persona.Salario(antiguedad));
    }
}