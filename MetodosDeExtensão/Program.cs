namespace MetodosDeExtensão;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite oque você quer inverter?");

            string frase = Console.ReadLine();

            Console.WriteLine("Sua frase é:" + frase!.InverterCaixas());
        }
        catch (Exception ex)
        {
            throw new ExceptionExtension(ex);
        }      
    }
}
