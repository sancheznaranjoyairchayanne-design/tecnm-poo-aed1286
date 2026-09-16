namespace Hito1_Encapsulamiento;

public class Persona
{
    // Campos privados
    private string _nombre;
    private int _edad;

    // Propiedades públicas con validación
    public string Nombre
    {
        get { return _nombre; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            _nombre = value.Trim();
        }
    }

    public int Edad
    {
        get { return _edad; }
        private set
        {
            if (value < 0 || value > 125)
                throw new ArgumentException("La edad debe estar entre 0 y 125 años.");
            _edad = value;
        }
    }

    // Constructor principal
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Constructor secundario (delegación con : this)
    public Persona(string nombre) : this(nombre, 0) { }

    // Método Cumpl: ejemplo de regla de negocio
    public bool Cumpl()
    {
        // Devuelve true si la persona es mayor de edad
        return Edad >= 18;
    }
}

