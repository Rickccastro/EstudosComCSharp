namespace CovarianciaEContravariancia;
internal interface IArmazenador<in T>
{
    /*Entrando "IN" dados mais genericos*/
   void Armazenar(T item);   
}
