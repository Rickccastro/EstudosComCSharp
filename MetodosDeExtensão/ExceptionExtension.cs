namespace MetodosDeExtensão;

public class ExceptionExtension : Exception
{
    private readonly Exception exceptionCtor = new Exception();
    public ExceptionExtension(Exception exceptionCtor)
    {

        this.exceptionCtor = exceptionCtor;
    }

    public ExceptionExtension(string message)
          : base(message)
    {

    }

    public ExceptionExtension(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ExceptionExtension ExceptionMy(string customMessage)
    {
        return new ExceptionExtension(customMessage);
    }
}
