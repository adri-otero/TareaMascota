using System;

public class Mascota
{
    private string nombre;
    private int edad;
    private string tipo;
    private string sonido;

    public Mascota(string nom, int ed, string tip, string son)
    {
        nombre = nom;
        edad = ed;
        tipo = tip;
        sonido = son;
    }

    public void EmitirSonido()
    {
        Console.WriteLine(sonido);
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Tipo: {tipo}");
        Console.WriteLine($"Sonido: {sonido}");
    }

    public int GetEdad()
    {
        return edad;
    }

    public void SetEdad(int nuevaEdad)
    {
        if (nuevaEdad >= 0)
        {
            edad = nuevaEdad;
            Console.WriteLine($"La edad de {nombre} se ha actualizado a {nuevaEdad} años.");
        }
        else
        {
            Console.WriteLine($"Error: La edad de {nombre} no puede ser negativa ({nuevaEdad}). No se realizó el cambio.");
        }
    }

    public int CalcularEdadHumana()
    {
        int edadHumana = edad * 7;
        return edadHumana;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Mascota 1: Firulais (Perro) ---");
        Mascota miMascota1 = new Mascota("Firulais", 3, "perro", "Guau guau!");

        miMascota1.EmitirSonido();
        miMascota1.MostrarInformacion();

        Console.WriteLine($"Edad humana de {miMascota1.GetEdad()} años de {miMascota1.nombre}: {miMascota1.CalcularEdadHumana()} años humanos.");

        Console.WriteLine("\n--- Cambiando la edad de Firulais ---");
        miMascota1.SetEdad(5);

        Console.WriteLine($"Nueva edad de {miMascota1.nombre} usando GetEdad: {miMascota1.GetEdad()} años.");
        Console.WriteLine($"Nueva edad humana de {miMascota1.GetEdad()} años de {miMascota1.nombre}: {miMascota1.CalcularEdadHumana()} años humanos.");

        Console.WriteLine("\n--- Mascota 2: Michi (Gato) ---");
        Mascota miMascota2 = new Mascota("Michi", 2, "gato", "Miau!");

        miMascota2.EmitirSonido();
        miMascota2.MostrarInformacion();
        Console.WriteLine($"Edad humana de {miMascota2.GetEdad()} años de {miMascota2.nombre}: {miMascota2.CalcularEdadHumana()} años humanos.");

        Console.WriteLine("\n--- Probando SetEdad con valor inválido para Michi ---");
        miMascota2.SetEdad(-1);
        Console.WriteLine($"Edad de {miMascota2.nombre} después de intento inválido: {miMascota2.GetEdad()} años.");
    }
}