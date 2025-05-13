namespace TP4_Creando_Ahorcado;

public class Ahorcado
{
    public int intentos {get; private set;}
    public static List<string> posiblesPalabras {get; private set;}
    public static string palabraElegida = elegirPalabra();
    public static string elegirPalabra()
    {
        posiblesPalabras = new List<string>();
        posiblesPalabras.Add("COMPUTADORA");
        posiblesPalabras.Add("INFORMATICA");
        posiblesPalabras.Add("ZAPATO");
        posiblesPalabras.Add("APROBAME");
        posiblesPalabras.Add("GRACIAS");
        Random random = new Random();
        int clavePalabra = random.Next(0, 4);
        return posiblesPalabras[clavePalabra];
    }
    public static string devolverPalabra()
    {
        return palabraElegida;
    }
    public static bool chequearLetra(char letraAdivinada)
    {
        bool coinciden = false;
        foreach (char letra in palabraElegida)
        {
            if (letraAdivinada == letra)
            {
                coinciden = true;
            }
        }
        return coinciden;
    }
    public static bool chequearPalabra(string palabraAdivinada)
    {
        bool coinciden = false;
            if (palabraAdivinada == palabraElegida)
            {
                coinciden = true;
            }
        return coinciden;
    }
}