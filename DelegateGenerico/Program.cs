namespace DelegateGenerico;

internal class Program
{
    delegate int CalculoMatematico(int a ,int b);

    delegate T DelegateGenerico<T>(T a , T b);

    static void Main(string[] args)
    {
        /*Estatico só aceita funções do tipo INT*/
        CalculoMatematico calculo = new CalculoMatematico(Somar);
        Console.WriteLine(calculo(1, 1));

        // Generica aceita funções de quaquer tipo
        DelegateGenerico<int> genericoInt = new DelegateGenerico<int>(Somar);
        Console.WriteLine(genericoInt(1, 1));

        // Generica aceita funções de quaquer tipo
        DelegateGenerico<decimal> genericoDecimal = new DelegateGenerico<decimal>(SomarDecimal);
        Console.WriteLine(genericoDecimal(1, 1));

        /*Delegate do tipo Func serve para não ter a necessidade da declaração do delegate no escopo global
         e não serve para metodos voids*/
        Func<int, int, int> funcCalculo = (Somar);
        Console.WriteLine(funcCalculo(1, 1));

        /*Delegate do tipo Action servem para os metodos voids,podem receber parametros mas não retornam nada*/
        Action<int> actionImprimirCalculo = (ImprimirResultado);
        actionImprimirCalculo(funcCalculo(1,1));   
    }

    private static void ImprimirResultado(int resultado)
    {
        Console.WriteLine(resultado);
    }

    static int Somar(int a ,int b)
    {
        return a + b;
    }

    static decimal SomarDecimal(decimal a, decimal b) 
    {
        return a + b;
    }
}
