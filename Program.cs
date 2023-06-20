using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Calculadora numero = new(ingresarNumero());

        Console.WriteLine("El numero es: " + numero.Resultado);

        double opcion=0;
        double termino=0;
        double flag;
        do
        {
            Console.WriteLine("------ Operaciones ------");
            Console.WriteLine("1) Sumar");
            Console.WriteLine("2) Restar");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Dividir");
            Console.WriteLine("5) Limpiar");

            opcion = ingresarNumero();

            termino = ingresarNumero();

            switch (opcion)
            {
                case 1:
                    numero.Sumar(termino);
                    break;
                case 2:
                    numero.Restar(termino);
                    break;
                case 3:
                    numero.Multiplicar(termino);
                    break;
                case 4:
                    numero.Dividir(termino);
                    break;
                default:
                    numero.Limpiar();
                    break;
            }

            Console.WriteLine("El numero es: " + numero.Resultado);

            Console.WriteLine("Quiere continuar? (0=no, 1=si)");
            flag = ingresarNumero();

        } while (flag == 1);

        Console.WriteLine("El numero es: " + numero.Resultado);
    }

    public static double ingresarNumero()
    {
        string? cadena;
        double numero = 0;   
        bool control = false;
        do
        {
            Console.WriteLine("Ingrese un numero");
            cadena = Console.ReadLine();
            control = double.TryParse(cadena, out numero);
        } while (!control);
        return numero;
    }
}