namespace TP4_Creando_Ahorcado;

public class Ahorcado
{
    public int intentos {get; private set;}
    public static List<string> posiblesPalabras {get; private set;}
    public static string elegirPalabra()
    {
        string palabra = "";
        posiblesPalabras = new List<string>();
        posiblesPalabras.Add("COMPUTADORA");
        posiblesPalabras.Add("INFORMATICA");
        posiblesPalabras.Add("ZAPATO");
        posiblesPalabras.Add("APROBAME");
        posiblesPalabras.Add("GRACIAS");
        Random random = new Random();
        int clavePalabra = random.Next(0, 4);
        palabra = posiblesPalabras[clavePalabra];
        return palabra;
    }
}