namespace TP4_Creando_Ahorcado;

public class Ahorcado
{
    public int intentos {get; private set;}
    public static List<string> posiblesPalabras {get; private set;}= new List<string>();
    public static string palabraElegida = elegirPalabra();
    static char[] arrayPalabra = esconderPalabra();
    private static string elegirPalabra()
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
    public static char[] devolverPalabra()
    {
        return arrayPalabra;
    }
    public static void chequearLetra(char letraAdivinada)
    {
        for (int i = 0; i < palabraElegida.Length; i++)
        {
            if (letraAdivinada == palabraElegida[i])
            {
                arrayPalabra[i] = letraAdivinada;
            }
        }
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
    private static char[] esconderPalabra()
    {
        char[] palabraEscondida = new char[palabraElegida.Length];
        for (int i = 0; i < palabraElegida.Length; i++)
        {
            palabraEscondida[i] = '_';
        }
        return palabraEscondida;
    }
}