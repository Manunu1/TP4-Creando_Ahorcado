namespace TP4_Creando_Ahorcado;

public class Ahorcado
{
    public int intentos {get; private set;}
    public static List<string> posiblesPalabras {get; private set;}
    public static void elegirPalabra()
    {
        string palabra;
        posiblesPalabras = new List<string>();
        posiblesPalabras.Add("COMPUTADORA");
        posiblesPalabras.Add("INFORMATICA");
        posiblesPalabras.Add("ZAPATO");
        posiblesPalabras.Add("APROBAME");
        posiblesPalabras.Add("GRACIAS");
        Random random = new Random();
        int clavePalabra = random.Next(1, 5);
        switch (clavePalabra)
        {
            case 1:
            palabra = posiblesPalabras[clavePalabra];
            break;
            case 2:
            palabra = posiblesPalabras[clavePalabra];
            break;
            case 3:
            palabra = posiblesPalabras[clavePalabra];
            break;
            case 4:
            palabra = posiblesPalabras[clavePalabra];
            break;
            case 5:
            palabra = posiblesPalabras[clavePalabra];
            break;
        }
    }
}