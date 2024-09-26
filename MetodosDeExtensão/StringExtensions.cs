using System.Diagnostics;

namespace MetodosDeExtensão;

public static class StringExtensions 
{
    public static string InverterCaixas(this string frase )
    {
        bool isUperCase = true;
        string resultado = ""; 

        for (int i = 0; i < frase.Length; i++)
        {
            resultado += isUperCase ? frase[i].ToString().ToUpper() : frase[i].ToString().ToLower();
            isUperCase = !isUperCase;
        }
        return resultado;
    }
}
