namespace CovarianciaEContravariancia;
internal interface IRecuperador<out T>
{
    /*Saindo "Out" os dados*/
    T Recuperar(int codigo);
}
