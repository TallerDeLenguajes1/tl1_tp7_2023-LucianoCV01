namespace EspacioEmpleado;
class Empleado
{
    string? nombre;
    string? apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    char genero;
    DateTime fechaIngreso;
    double sueldoBasico;
    cargos cargo;

    public Empleado(string? nombre, string? apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, cargos cargo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaNacimiento = fechaNacimiento;
        this.EstadoCivil = estadoCivil;
        this.Genero = genero;
        this.FechaIngreso = fechaIngreso;
        this.SueldoBasico = sueldoBasico;
        this.Cargo = cargo;
    }

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargos Cargo { get => cargo; set => cargo = value; }

    public int CalcularAntigüedad()
    {
        var hoy = DateTime.Now;
        return ((hoy.Subtract(fechaIngreso).Days) / 365);
    }
    public int CalcularEdad()
    {
        var hoy = DateTime.Now;
        return (int)((hoy.Subtract(fechaNacimiento).TotalDays) / 365.25); //Mayor Precisión, tiene en cuenta años bisiestos
    }
    public int CalcularJubilacion(int edad)
    {
        int jubilacion = 0;
        if (genero == 'f' || genero == 'F')
        {
            jubilacion = 60 - edad;
        } else
        {
            jubilacion = 65 - edad;
        }
        return jubilacion;
    }
    public double Salario(int antiguedad)
    {
        double adicional=0;
        if (antiguedad < 20)
        {
            adicional += (sueldoBasico * antiguedad)/100;
        } else
        {
            adicional += (sueldoBasico * 25)/100;
        }
        if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
        {
            adicional += (adicional * 50)/100;
        }
        if (estadoCivil == 'c' || estadoCivil == 'C')
        {
            adicional += 15000;
        }
        return sueldoBasico + adicional;
    }

}
public enum cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}