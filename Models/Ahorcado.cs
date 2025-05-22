namespace TP4_Creando_Ahorcado;

public class Ahorcado
{
    public  int intentos = 0;
    public  List<string> posiblesPalabras = new List<string>();
    public  string palabraElegida;
    public char[] arrayPalabra;
    public  List<char> letrasUsadas = new List<char>();
    public  string elegirPalabra()
    {
        posiblesPalabras = new List<string>();
        posiblesPalabras.Add("COMPUTADORA");
        posiblesPalabras.Add("INFORMATICA");
        posiblesPalabras.Add("ZAPATO");
        posiblesPalabras.Add("APROBAME");
        posiblesPalabras.Add("GRACIAS");
        Random random = new Random();
        int clavePalabra = random.Next(0, 4);
        palabraElegida = posiblesPalabras[clavePalabra];
        arrayPalabra = esconderPalabra();
        return palabraElegida;
    }
    public  char[] devolverPalabra()
    {
        return arrayPalabra;
    }
    public  void chequearLetra(char letraAdivinada)
    {
        for (int i = 0; i < palabraElegida.Length; i++)
        {
            if (letraAdivinada == palabraElegida[i])
            {
                arrayPalabra[i] = letraAdivinada;
            }
        }
        if (!letrasUsadas.Contains(letraAdivinada))
        {
            intentos++;
            letrasUsadas.Add(letraAdivinada);
        }
    }
    public  bool chequearPalabra(string palabraAdivinada)
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
    private char[] esconderPalabra()
    {
        char[] palabraEscondida = new char[palabraElegida.Length];
        for (int i = 0; i < palabraElegida.Length; i++)
        {
            palabraEscondida[i] = '_';
        }
        return palabraEscondida;
    }
    public  int devolverIntentos()
    {
        return intentos;
    }
    public  List<char> devolverLetrasUsadas()
    {
        return letrasUsadas;
    }
}