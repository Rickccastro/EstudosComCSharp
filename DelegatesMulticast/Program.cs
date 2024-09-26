namespace DelegatesMulticast;

internal class Program
{
    delegate void VerificacaoIdade(int idade);
    static VerificacaoIdade verificacaoIdade;

    static void Main(string[] args)
    {

        Console.WriteLine("Digite seu sexo:");
        string sexoUsuario = Console.ReadLine();
        Console.WriteLine("Digite sua idade:");
        int  idade = Convert.ToInt32(Console.ReadLine());

        if(sexoUsuario == "H")
        {
            verificacaoIdade = new VerificacaoIdade(VerificaIdadeHomens);  
            verificacaoIdade += VerificaPesoHomens;  
        }
        else
        {
            verificacaoIdade = new VerificacaoIdade(VerificaIdadeMulher);
            verificacaoIdade += VerificaPesoMulher;
        }

        verificacaoIdade(idade);    
    }
    static void VerificaIdadeHomens(int idade)
    {
        if (idade < 21)
        {
            Console.WriteLine("Ainda está crescendo");
        }
        else
        {
            Console.WriteLine("Já cresceu");

        }

    }
    static void VerificaIdadeMulher(int idade)
    {
        if (idade < 18)
        {
            Console.WriteLine("Ainda está crescendo");
        }
        else
        {
            Console.WriteLine("Já cresceu");

        }
    }


    static void VerificaPesoHomens(int idade)
    {
        if (idade < 21)
        {
            Console.WriteLine("Não pode pegar muito peso");
        }
        else
        {
            Console.WriteLine("Já pode pegar muito peso");

        }

    }

    static void VerificaPesoMulher(int idade)
    {
        if (idade < 18)
        {
            Console.WriteLine("Já pode pegar peso");
        }
        else
        {
            Console.WriteLine("Não pode pegar muito peso");

        }
    }
}
