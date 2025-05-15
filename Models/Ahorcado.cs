namespace TP4_Creando_Ahorcado;

public class Ahorcado
{
    public static int intentos = 0;
    public static List<string> posiblesPalabras = new List<string>();
    public static string palabraElegida = elegirPalabra();
    static char[] arrayPalabra = esconderPalabra();
    public static List<char> letrasUsadas = new List<char>();
    static bool adivinoPalabra = false;
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
        intentos++;
        letrasUsadas.Add(letraAdivinada);
    }
    public static bool chequearPalabra(string palabraAdivinada)
    {
            if (palabraAdivinada == palabraElegida)
            {
                return true ;          
            }
            else
            {
                return false;
            }
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
    public static int devolverIntentos()
    {
        return intentos;
    }
    public static List<char> devolverLetrasUsadas()
    {
        return letrasUsadas;
    }
}