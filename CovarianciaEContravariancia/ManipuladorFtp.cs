namespace CovarianciaEContravariancia;
internal class ManipuladorFtp <T> : IRecuperador<T>, IArmazenador<T>
{
    private List<T> _list = new List<T> ();

    public void Armazenar(T item)
    {
        _list.Add(item);
    }

    public T Recuperar(int codigo)
    {
       return _list[codigo];
    }
}