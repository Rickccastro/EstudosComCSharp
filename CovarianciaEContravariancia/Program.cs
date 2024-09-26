namespace CovarianciaEContravariancia;

internal class Program
{
    static void Main(string[] args)
    {
        ManipuladorFtp<Nivel2> ftp = new ManipuladorFtp<Nivel2>();

        /*Interface In indo do especifico para o generico*/
        IArmazenador<Nivel3> armazenador = ftp;

        armazenador.Armazenar(new Nivel3());

        /*Interface Out indo do generico para o especifico*/
        /*Recuperando qualquer objeto armazenado de qualquer nível*/
        IRecuperador<Nivel1> recuperador = ftp;

        Console.WriteLine(recuperador.Recuperar(0));
        
    }
}
