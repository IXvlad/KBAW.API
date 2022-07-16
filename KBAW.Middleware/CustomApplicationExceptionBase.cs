namespace KBAW.ErrorHandler;

public class CustomApplicationExceptionBase : ApplicationException
{
    public CustomApplicationExceptionBase()
    {
        //
    }

    protected CustomApplicationExceptionBase(string message)
        : base(message)
    {
        //
    }

    protected CustomApplicationExceptionBase(string message, Exception innerException)
        : base(message, innerException)
    {
        //
    }
}