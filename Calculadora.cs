namespace EspacioCalculadora;

class Calculadora
{
    private double dato;

    public Calculadora()
    {
        this.dato = 0;
    }
    public Calculadora(double dato)
    {
        this.dato = dato;
    }

    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            dato /= termino;
        }
    }
    public void Limpiar()
    {
        dato = 0;
    }

    public double Resultado { get => dato; }
}